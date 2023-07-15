# HTML Introduction:

- HTML stands for Hyper Text Markup Language.
- It describes the structure of a web page, and basically tells the browser how to display the content.
- It consists of a series of tags called HTML elements.

# HTML Basics:

## HTML Documents
- All HTML documents must start with a document type declaration: `<!DOCTYPE html>`.
- The HTML document itself begins with `<html>` and ends with `</html>`.
- The visible part of the HTML document is between `<body>` and `</body>`.

Example:
```
<!DOCTYPE html>
<html>

<head>
</head>

<body>

<h1>My First Heading</h1>
<p>My first paragraph.</p>

</body>
</html>
```

## The <!DOCTYPE> Declaration
- The `<!DOCTYPE>` declaration represents the document type, and helps browsers to display web pages correctly.
- It must only appear once, at the top of the page, before any HTML tags. The `<!DOCTYPE>` declaration is not case sensitive. 
- This declaration is for HTML5:

```
<!DOCTYPE html>
```

## HTML Headings
- HTML headings are defined with the `<h1>` to `<h6>` tags. `<h1>` defines the most important heading whereas `<h6>` defines the least important one.

Example:

```
<h1>This is heading 1</h1>
<h2>This is heading 2</h2>
<h3>This is heading 3</h3>
```

## HTML Paragraphs
- HTML paragraphs are defined with the `<p>` tag:

```
<p>This is a paragraph.</p>
<p>This is another paragraph.</p>
```

## HTML Links
- HTML links are defined with the `<a>` tag:

```
<a href="https://www.example.com">This is a link</a>
```

- The link's destination is specified in the href attribute. 

## HTML Images
- HTML images are defined with the `<img>` tag.
- The source file (src), alternative text (alt), width, and height are provided as attributes:

```
<img src="example.jpg" alt="example.com" width="104" height="142">
```

# HTML Elements:

- An HTML element is defined by a start tag, some content, and an end tag.

Example:

```
<h1>My First Heading</h1>
<p>My first paragraph.</p>
```

## Nested HTML Elements
- HTML elements can be nested (this means that elements can contain other elements).
- All HTML documents consist of nested HTML elements.

## Never Skip the End Tag!

## Empty HTML Elements
- HTML elements with no content are called empty elements.
- The `<br>` tag defines a line break, and is an empty element without a closing tag:

Example:

```
<p>This is a <br> paragraph with a line break.</p>
```

## HTML is Not Case Sensitive
- HTML tags are not case sensitive: `<P>` means the same as `<p>`.

# HTML Attributes:

