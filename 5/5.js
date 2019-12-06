// With the unlimited use of these built in functions (split, reverse, and join) reverse words of a sentence without changing their position...
// Free example, "see me do it" has to be "ees em od ti".
//  your output has to be a string, NOT AN ARRAY. 
// With the spirit of the party, if you feel like you need regex...here are a few:
// /(?=\S)/ - matches single characters.
//  /\b/ - searches a whole word character - word boundary
// /a-z/ - searches for alphabets a to z.
// You can also use the knowledge of regex used on your string calculator or password checker.



const array = (string) => {
    return string.split(/\b/)
        .map(word => word.split(/(?=\S)/)
        .reverse()
        .join(""))
     .join("");
}
console.log(array("see me do it"));