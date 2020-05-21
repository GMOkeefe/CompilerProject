using System;
using System.IO;
using System.Security;

namespace GMOKeefe.Compiler.Lexer
{
    /// <summary>
    /// Tokenizes text files for parsing.
    /// </summary>
    public class Tokenizer
    {
        private const long MAX_LENGTH = 2048;
        private IReader reader;

        /// <summary>
        /// Constructs a Tokenizer to break down the given file.
        /// </summary>
        /// <param name="path">
        /// The path of the file to be lexed.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when the file path is null.
        /// </exception>
        public Tokenizer(string path)
        {
            try
            {
                long length = new FileInfo(path).Length;

                if (length > MAX_LENGTH)
                {
                    this.reader = new LineReader(path);
                }
                else
                {
                    this.reader = new FullReader(path);
                }
            }
            catch (ArgumentNullException e)
            {
                // path is null
                throw e;
            }
            catch (ArgumentException e)
            {
                // argument is malformed
                Console.Error.Write(e.ToString());
                Console.Error.Write("Path to file invalid: \"" + path + "\".");
                System.Environment.Exit(1);
            }
            catch (DirectoryNotFoundException e)
            {
                // directory path is invalid
                Console.Error.Write(e.ToString());
                Console.Error.Write("Directory path is invalid: \"" + path + "\".");
                System.Environment.Exit(1);
            }
            catch (FileNotFoundException e)
            {
                // file not found
                Console.Error.Write(e.ToString());
                Console.Error.Write("File not found: \"" + path + "\".");
                System.Environment.Exit(1);
            }
            catch (OutOfMemoryException e)
            {
                // not enough memory to allocate buffer
                Console.Error.Write(e.ToString());
                Console.Error.Write("Out of memory when reading file: \"" + path + "\".");
                System.Environment.Exit(1);
            }
            catch (PathTooLongException e)
            {
                // path too long
                Console.Error.Write(e.ToString());
                Console.Error.Write("Path too long: \"" + path + "\".");
                System.Environment.Exit(1);
            }
            catch (IOException e)
            {
                // an IO error occurred
                Console.Error.Write(e.ToString());
                Console.Error.Write("An IO error occurred while opening this file: \"" + path + "\".");
                System.Environment.Exit(1);
            }
            catch (NotSupportedException e)
            {
                // filename not a supported format
                Console.Error.Write(e.ToString());
                Console.Error.Write("Path format not supported: \"" + path + "\".");
                System.Environment.Exit(1);
            }
            catch (SecurityException e)
            {
                // caller does not have permission
                Console.Error.Write(e.ToString());
                Console.Error.Write("Permission to access \"" + path + "\" denied.");
                System.Environment.Exit(1);
            }
            catch (UnauthorizedAccessException e)
            {
                // access is denied
                Console.Error.Write(e.ToString());
                Console.Error.Write("Permission to access \"" + path + "\" denied.");
                System.Environment.Exit(1);
            }
        }

        /// <summary>
        /// Returns the full text of the code.
        /// </summary>
        /// <returns>
        /// The text of the file given to the Lexer.
        /// </returns>
        public string Text()
        {
            string text = "";

            while (!reader.Done())
            {
                text += reader.Read();
            }

            return text;
        }
    }
}