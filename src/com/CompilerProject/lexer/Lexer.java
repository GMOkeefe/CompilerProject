package com.CompilerProject.lexer;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.io.File;
import java.io.FileNotFoundException;

public class Lexer {
    private enum LexerMode {
        PUNCTUATOR_MODE,
        PARENTHETICAL_MODE,
        WHITESPACE_MODE,
        NON_FORMATTING_MODE,
        NON_READING_MODE
    }

    private final int MAX_LINES = 512;

    private File in;
    private LexerMode mode;

    public Lexer(File in)
    {
        this.in = in;
        mode = LexerMode.NON_READING_MODE;
    }

    public List<String> tokenize()
    {
        String text = echo(MAX_LINES);
        List<String> tokens = new ArrayList<String>();
        String curr = "";
        int ptr = 0;

        while (ptr < text.length())
        {
            char c = text.charAt(ptr);
            LexerMode m = checkMode(c);

            if ((checkMode(c) == mode
                && checkMode(c) != LexerMode.PARENTHETICAL_MODE)
                || mode == LexerMode.NON_READING_MODE)
            {
                if (mode == LexerMode.NON_READING_MODE)
                {
                    mode = checkMode(c);
                }
                curr += c;
                ptr++;
            }
            else if (mode == LexerMode.WHITESPACE_MODE)
            {
                mode = checkMode(c);
                curr = "";
            }
            else if (checkMode(c) == LexerMode.PARENTHETICAL_MODE)
            {
                if (mode != LexerMode.WHITESPACE_MODE)
                {
                    tokens.add(curr);
                }
                mode = LexerMode.PARENTHETICAL_MODE;
                curr = "" + c;
                ptr++;
            }
            else
            {
                if (mode != LexerMode.WHITESPACE_MODE)
                {
                    tokens.add(curr);
                }
                mode = checkMode(c);
                curr = "";
            }
        }

        return tokens;
    }

    public String echo(int numLines)
    {
        String txt = "";
        int ctr = 0;

        try (Scanner inScan = new Scanner(in))
        {
            while (inScan.hasNextLine() && ctr < numLines)
            {
                txt += inScan.nextLine().trim() + " ";
                ctr++;
            }
        }
        catch (FileNotFoundException e)
        {
            System.err.println("File not accessible");
        }

        return txt;
    }

    private LexerMode checkMode(char t)
    {
        if (",:".contains(""+t))
        {
            return LexerMode.PUNCTUATOR_MODE;
        }
        else if ("(){}[]".contains(""+t))
        {
            return LexerMode.PARENTHETICAL_MODE;
        }
        else if (" \n\r\t".contains(""+t))
        {
            return LexerMode.WHITESPACE_MODE;
        }
        else
        {
            return LexerMode.NON_FORMATTING_MODE;
        }
    }
}