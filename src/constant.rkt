#lang typed/racket

(define source (open-input-file "../example/constant.mza"))

(define (while/read [prev : (U EOF String)]) : String
  (cond
    [(eof-object? prev) ""]
    [else (string-append prev (while/read (read-line source 'return-linefeed)))]))

(define (clean [text : (Listof String)]) : (Listof String)
  (filter
   (λ ([elem : String]) : Boolean
     (not (equal? elem "")))
   text))

(define text (while/read ""))
(string->symbol text)
(clean (string-split text " "))
