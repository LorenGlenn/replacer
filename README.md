# Find & Repalce

#### By **Erik Killops, Loren Glenn**

## Description

Enter a sentence, a word you want replaced, a word to replace it with, and we'll do the rest!

#### Specs

| Expected Behavior                                                      | Input                                        | Output           |
|------------------------------------------------------------------------|----------------------------------------------|------------------|
| Replace a one word string with another word                            | "dog", "dog", "cat"                          | "cat"            |
| Replace one word in a multi word string with another                   | "the dog barked", "dog", "cat"               | "the cat barked" |
| Replace a partial string with another string                           | "the dog barked", "bark", "meow"             | "the dog meowed" |
| Replace a multi word string with another string                        | "the dog barked", "dog barked", "cat meowed" | "the cat meowed" |
| Handle inconsistent capitalization input and return a lowercase string | "tHe DOg baRkeD", "dOg", "CAt"               | "the cat barked" |

## Setup/Installation Requirements

Requires Windows and .Net

Clone repository, run ">dnx kestrel" in Powershell and visit "localhost:5004".

## Known Bugs

None.


## Technologies Used

HTML, C#, Nancy, Razor, Xunit.
