# Experimental Compiler Project
A project to write a compiler for a new programming language with no name as of yet.

## Implementation
The first form of the compiler is intended to be written in C#.

## Language Details
The language is multi-paradigmatic, with object-oriented and procedural elements. The final form of the language will have type inference through the ```var``` keyword, and will be statically and strongly typed. Many minor typographical changes between this language and the traditional C-like syntax have been made for educational purposes.

## Example Syntax:
```
(define function (sort)(Node n1, Node n2) -> (Node, Node):
	if n2 is NullItem:
		(n1, n2)
	elif n1 is NullItem:
		(n2, n1)
	elif n1 value > n2 value:
		(n2, n1)
	else:
		(n1, n2)

(define class (LinkedList):
	(define subinterface (Node)
		function (Add)(var item))

	(define subclass (Item : Node):
		var value
		Node next

		(define constructor (NextItem)(var value):
			this value = value
			this next = NullItem)

		(define constructor (Item)(var value, Node next):
			this value = value
			this next = next)

		(define function (Add)(var item):
			if next is NullItem:
				next = NextItem(item)
			else:
				next Add(item)))

	(define subclass (NullItem : Node))

	Node head

	(define constructor (LinkedList)(var item):
		head = Item(item, NullItem))

	(define function (Add)(var item):
		head Add(item)))


(redefine function (sort)(Node n1, Node n2) -> (Node, Node):
	(n1, n2))

(define main (var args) -> int:
	LinkedList list = LinkedList(4)
	list Add(5)
	list Add(6)
	
	(list head value))
```
