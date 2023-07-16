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
- Headings Are Important: search engines use the headings to index the structure and content of your web pages. - 
- Users often skim a page by its headings. It is important to use headings to show the document structure.

```
<h1>This is heading 1</h1>
<h2>This is heading 2</h2>
<h3>This is heading 3</h3>
```

- Each HTML heading has a default size. However, you can specify the size for any heading with the style attribute, using the CSS font-size property:

```
<h1 style="font-size:60px;">Heading 1</h1>
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

```
<p>This is a <br> paragraph with a line break.</p>
```

## HTML is Not Case Sensitive
- HTML tags are not case sensitive: `<P>` means the same as `<p>`.

# HTML Attributes:
- HTML attributes provide additional information about HTML elements.
- All HTML elements can have attributes. Attributes provide additional information about elements.
- Attributes are always specified in the start tag.
- Attributes usually come in name/value pairs like: name="value".

## The href Attribute

- The `<a>` tag defines a hyperlink. The href attribute specifies the URL of the page the link goes to:

```
<a href="https://www.example.com">This is a link</a>
```

## The src Attribute
- The `<img>` tag is used to embed an image in an HTML page. The src attribute specifies the path to the image to be displayed:

```
<img src="img_girl.jpg">
```

## The width and height Attributes
- The `<img>` tag should also contain the width and height attributes, which specify the width and height of the image (in pixels):

```
<img src="img_girl.jpg" width="500" height="600">
```

## The alt Attribute
- The required alt attribute for the `<img>` tag specifies an alternate text for an image, if the image for some reason cannot be displayed. This can be due to a slow connection, or an error in the src attribute, or if the user uses a screen reader.
Example:

```
<img src="img_girl.jpg" alt="Girl with a jacket">
```

## The style Attribute
- The style attribute is used to add styles to an element, such as color, font, size, and more.

```
<p style="color:red;">This is a red paragraph.</p>
```

## The lang Attribute
- You should always include the lang attribute inside the `<html>` tag, to declare the language of the Web page. This is meant to assist search engines and browsers.
- The following example specifies English as the language:

```
<!DOCTYPE html>
<html lang="en">
<body>
...
</body>
</html>
```
- Country codes can also be added to the language code in the lang attribute. So, the first two characters define the language of the HTML page, and the last two characters define the country.
- The following example specifies English as the language and United States as the country:

```
<!DOCTYPE html>
<html lang="en-US">
<body>
...
</body>
</html>
```

## The title Attribute
- The title attribute defines some extra information about an element.
- The value of the title attribute will be displayed as a tooltip when you mouse over the element:

```
<p title="I'm a tooltip">This is a paragraph.</p>
```

## Good tips with HTML Attributes
- Use Lowercase Attributes.
- Quote Attribute Values.