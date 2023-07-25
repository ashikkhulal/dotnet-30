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

## HTML Display:
- You cannot be sure how HTML will be displayed. Large or small screens, and resized windows will create different results.
- With HTML, you cannot change the display by adding extra spaces or extra lines in your HTML code. The browser will automatically remove any extra spaces and lines when the page is displayed.

## The HTML <pre> Element
- The HTML <pre> element defines preformatted text.
- The text inside a <pre> element is displayed in a fixed-width font (usually Courier), and it preserves both spaces and line breaks:

```
<pre>
    My Bonnie lies over the ocean.

    My Bonnie lies over the sea.

    My Bonnie lies over the ocean.

    Oh, bring back my Bonnie to me.
</pre>
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

### HTML Link Breaks
- The `<br>` tag defines a line break, and is an empty element without a closing tag:

```
<p>This is a <br> paragraph with a line break.</p>
```

### HTML Horizontal Rules
- The <hr> tag defines a thematic break in an HTML page, and is most often displayed as a horizontal rule.
- The <hr> tag is an empty tag, which means that it has no end tag.
- The <hr> element is used to separate content (or define a change) in an HTML page:

```
<h1>This is heading 1</h1>
<p>This is some text.</p>
<hr>
<h2>This is heading 2</h2>
<p>This is some other text.</p>
<hr>
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
<tagname style="property:value;">
```

### Text Color 
- The CSS color property defines the text color for an HTML element:

```
<p style="color:red;">This is a red paragraph.</p>
```

### Fonts
- The CSS font-family property defines the font to be used for an HTML element:

```
<h1 style="font-family:verdana;">This is a heading</h1>
<p style="font-family:courier;">This is a paragraph.</p>
```

### Background Color
- The CSS background-color property defines the background color for an HTML element.

```
<body style="background-color:powderblue;">

<h1>This is a heading</h1>
<p>This is a paragraph.</p>

</body>
```

### Text Size
- The CSS font-size property defines the text size for an HTML element:

```
<h1 style="font-size:300%;">This is a heading</h1>
<p style="font-size:160%;">This is a paragraph.</p>
```

### Text Alignment
- The CSS text-align property defines the horizontal text alignment for an HTML element:

```
<h1 style="text-align:center;">Centered Heading</h1>
<p style="text-align:center;">Centered paragraph.</p>
```

## HTML Formatting Elements
Formatting elements were designed to display special types of text:

- <b> - Bold text
- <strong> - Important text
- <i> - Italic text
- <em> - Emphasized text
- <mark> - Marked text
- <small> - Smaller text
- <del> - Deleted text
- <ins> - Inserted text
- <sub> - Subscript text
- <sup> - Superscript text

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

## HTML <blockquote> for Quotations
- The HTML <blockquote> element defines a section that is quoted from another source.
- Browsers usually indent <blockquote> elements.

## HTML <q> for Short Quotations
- The HTML <q> tag defines a short quotation. Browsers normally insert quotation marks around the quotation.

## HTML <abbr> for Abbreviations
- The HTML <abbr> tag defines an abbreviation or an acronym, like "HTML", "CSS", "Mr.", "Dr.", "ASAP", "ATM".
- Marking abbreviations can give useful information to browsers, translation systems and search-engines.
- Tip: Use the global title attribute to show the description for the abbreviation/acronym when you mouse over the element. 

## HTML <address> for Contact Information
- The HTML <address> tag defines the contact information for the author/owner of a document or an article.
- The contact information can be an email address, URL, physical address, phone number, social media handle, etc.
- The text in the <address> element usually renders in italic, and browsers will always add a line break before and after the <address> element.

## HTML <cite> for Work Title
- The HTML <cite> tag defines the title of a creative work (e.g. a book, a poem, a song, a movie, a painting, a sculpture, etc.).
- Note: A person's name is not the title of a work.
- The text in the <cite> element usually renders in italic.

## HTML <bdo> for Bi-Directional Override
 - BDO stands for Bi-Directional Override. The HTML <bdo> tag is used to override the current text direction

# HTML Colors
- HTML colors are specified with predefined color names, or with RGB, HEX, HSL, RGBA, or HSLA values.
- You can set the background color for HTML elements.
- You can set the color of text.
- You can set the color of borders.
