package com.CompilerProject;

import com.CompilerProject.lexer.Lexer;

import java.io.File;

public class Main
{
    public static void main(String[] args)
    {
        File inFile = new File("example/constant.mza");
        String fileText;
        String tokenized;

        Lexer l = new Lexer(inFile);
        fileText = l.echo(512);
        tokenized = l.tokenize().toString();

        System.out.println(fileText);
        System.out.println(tokenized);
    }
}