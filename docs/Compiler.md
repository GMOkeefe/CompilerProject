# Compiler.dll v.1.0.0.0 API documentation

# All types

|   |   |   |
|---|---|---|
| [FullReader Class](#fullreader-class) | [Tokenizer Class](#tokenizer-class) | [IExpression Class](#iexpression-class) |
| [IReader Class](#ireader-class) | [BoolExpr Class](#boolexpr-class) | [IValue Class](#ivalue-class) |
| [LineReader Class](#linereader-class) | [BoolValue Class](#boolvalue-class) |   |
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
# Tokenizer Class

Namespace: GMOKeefe.Compiler.Lexer

Tokenizes text files for parsing.

## Constructors

| Name | Summary |
|---|---|
| **Tokenizer(string path)** | Constructs a Tokenizer to break down the given file. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| **Tokens()** | List\<string\> | Tokenizes the text file in a way that is more interpretable to the compiler. |
# BoolExpr Class

Namespace: GMOKeefe.Compiler.Syntax

Expression that contains a boolean value.

## Constructors

| Name | Summary |
|---|---|
| **BoolExpr(bool value)** | Creates a BoolExpr based on a given boolean. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| **Eval()** | [IValue](#ivalue-class) | Returns the IValue that this Expression evaluates to. |
# BoolValue Class

Namespace: GMOKeefe.Compiler.Syntax

Representation of a boolean value.

## Constructors

| Name | Summary |
|---|---|
| **BoolValue(bool value)** | Creates a BoolValue based on the given value. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| **Value()** | Object | Retrieves the actual value of this IValue. |
# IExpression Class

Namespace: GMOKeefe.Compiler.Syntax

Interface for any AST Expression.

## Methods

| Name | Returns | Summary |
|---|---|---|
| **Eval()** | [IValue](#ivalue-class) | Evaluates the expression and returns the value. |
# IValue Class

Namespace: GMOKeefe.Compiler.Syntax

The abstract representation of a value.

## Methods

| Name | Returns | Summary |
|---|---|---|
| **Value()** | Object | Generates the native value. |
