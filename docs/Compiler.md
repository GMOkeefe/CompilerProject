# Compiler.dll v.1.0.0.0 API documentation

# All types

|   |   |   |
|---|---|---|
| [FullReader Class](#fullreader-class) | [Lexer Class](#lexer-class) |   |
| [IReader Class](#ireader-class) | [LineReader Class](#linereader-class) |   |
# FullReader Class

Namespace: GMOKeefe.Compiler.Lexer

Reads the given text file in its entirety.

## Constructors

| Name | Summary |
|---|---|
| **FullReader(string filePath)** | Creates a FullReader given the path of the file to be read. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| **Done()** | bool | Indicates whether the FullReader has been used or not. |
| **Read()** | string | Reads the text file. |
# IReader Class

Namespace: GMOKeefe.Compiler.Lexer

The Reader interface.\
Defines the functionality necessary for the Lexer to read code.

## Methods

| Name | Returns | Summary |
|---|---|---|
| **Done()** | bool | Indicates whether the Reader has been used or not. |
| **Read()** | string | Reads the text file, either whole or in part. |
# Lexer Class

Namespace: GMOKeefe.Compiler.Lexer

Tokenizes text files for parsing.

## Methods

| Name | Returns | Summary |
|---|---|---|
| **echo(string input)** | string | Returns the input string for testing purposes. |
# LineReader Class

Namespace: GMOKeefe.Compiler.Lexer

Reads the given text file line-by-line.

## Constructors

| Name | Summary |
|---|---|
| **LineReader(string filePath)** | Creates a LineReader given the path of the file to be read. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| **Done()** | bool | Indicates whether the LineReader has been used or not. |
| **Read()** | string | Reads one line of the text file. |
