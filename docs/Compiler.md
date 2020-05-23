# Compiler.dll v.1.0.0.0 API documentation

# All types

|   |   |   |
|---|---|---|
| [FullReader Class](#fullreader-class) | [IBody Class](#ibody-class) | [BoolValue Class](#boolvalue-class) |
| [IReader Class](#ireader-class) | [ParentBody Class](#parentbody-class) | [IExpression Class](#iexpression-class) |
| [LineReader Class](#linereader-class) | [StringBody Class](#stringbody-class) | [IValue Class](#ivalue-class) |
| [Organizer Class](#organizer-class) | [UnmatchedParenException Class](#unmatchedparenexception-class) |   |
| [Tokenizer Class](#tokenizer-class) | [BoolExpr Class](#boolexpr-class) |   |
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
# Organizer Class

Namespace: GMOKeefe.Compiler.Lexer

Organizes a list of string tokens into a hierarchical structure based on opening and closing symbols.

## Constructors

| Name | Summary |
|---|---|
| **Organizer(List\<string\> tokens)** | Creates a new Organizer based on a list of string tokens. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| **Organize()** | List\<[IBody](#ibody-class)\> | Organizes the string tokens into a list of IBodys. |
# Tokenizer Class

Namespace: GMOKeefe.Compiler.Lexer

Tokenizes text files for parsing.

## Constructors

| Name | Summary |
|---|---|
| **Tokenizer(string path)** | Constructs a Tokenizer to break down the given file. |
| **Tokenizer([IReader](#ireader-class) reader)** | Constructs a Tokenizer to utilize the given IReader to break down the text. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| **Tokens()** | List\<string\> | Tokenizes the text file in a way that is more interpretable to the compiler. |
# IBody Class

Namespace: GMOKeefe.Compiler.Parser

An interface that represents the union of the string and the list of IBodys.

## Methods

| Name | Returns | Summary |
|---|---|---|
| **Equals(Object obj)** | bool | Checks if the object is equal to another object. |
| **GetHashCode()** | int | Generates the hash code of this IBody. |
# ParentBody Class

Namespace: GMOKeefe.Compiler.Parser

An IBody that contains a list of IBody's.

## Constructors

| Name | Summary |
|---|---|
| **ParentBody()** | Creates a new ParentBody. |
| **ParentBody(List\<[IBody](#ibody-class)\> children)** | Creates a new ParentBody given a list of child IBodys. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| **AddChild([IBody](#ibody-class) child)** | void | Adds a new child IBody. |
| **Associate(string opener, List\<string\> rest)** | List\<string\> | Converts a list of strings into a list of bodies. Call when encountering an opening paren for the first time. |
| **Equals(Object obj)** | bool | Checks equality with any object. |
| **Equals([ParentBody](#parentbody-class) p)** | bool | Checks equality with another ParentBody. |
| **GetHashCode()** | int | Generates a hash code for this ParentBody. |
# StringBody Class

Namespace: GMOKeefe.Compiler.Parser

An IBody that contains a string.

## Constructors

| Name | Summary |
|---|---|
| **StringBody(string body)** | Creates a new StringBody. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| **Equals(Object obj)** | bool | Checks for equality with any object. |
| **Equals([StringBody](#stringbody-class) s)** | bool | Checks for equality with another StringBody. |
| **GetHashCode()** | int | Creates a hash code for the current StringBody. |
| **GetString()** | string | Retrieves the string that the StringBody contains. |
# UnmatchedParenException Class

Namespace: GMOKeefe.Compiler.Parser

Base class: Exception

An exception that represents a lack of a matching closing mark for a corresponding opening mark.

## Properties

| Name | Type | Summary |
|---|---|---|
| **TargetSite** | MethodBase |  |
| **StackTrace** | string |  |
| **Message** | string |  |
| **Data** | IDictionary |  |
| **InnerException** | Exception |  |
| **HelpLink** | string |  |
| **Source** | string |  |
| **HResult** | int |  |
## Constructors

| Name | Summary |
|---|---|
| **UnmatchedParenException(string paren)** | Creates a new UnmatchedParenException. |
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
