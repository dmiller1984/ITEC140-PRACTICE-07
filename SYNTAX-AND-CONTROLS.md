# Syntax and controls — study companion

## Names and visible wording

Use camelCase with the course-style prefix: `btnShowFace`, `picCardFace`, `txtFirstName`, `lblResult`. The prefix starts lowercase; later words start with capitals. Names are case-sensitive and contain no spaces.

**(Name)** identifies a control in code. **Text** is the wording a user sees. A PictureBox's picture is held in **Image**, not Text. Keep Form1 as the form's name.

The book's longer names and our class-style names can refer to the same roles. Use this repository's table consistently; do not mix identifiers from two examples.

## Identify the object before writing the statement

An assignment follows this pattern:

```csharp
controlName.Property = value;
```

The dot selects a property of that object. The equals sign assigns the value. A semicolon ends the statement. Replace the generic placeholders with real names before compiling.

- Text is a string. Written text needs straight double quotation marks; an empty string is `""`.
- Visible is Boolean. Use `true` or `false` without quotation marks.
- A DateTimePicker's Value is a DateTime. Convert it to display text when building a message.
- A method call uses parentheses. For example, `this.Close();` closes this form.

## Designer versus runtime

Double-click a Button in **Form1.cs [Design]** to generate its Click handler. A single click on that button in the running app executes the handler. Put your statements between that handler's opening brace and closing brace.

`Form1.cs` holds your event code. `Form1.Designer.cs` holds the GUI code maintained by the Designer; make normal layout changes in the Designer. `Program.cs` starts the app. `Form1.resx` stores form resources when used.

If you accidentally make a handler, clear its connection in **Properties > Events (lightning bolt)** before deleting the unused method. Do not delete only one side of the connection.

## Class reminders

Richard's September 9 class discussion covered Image, SizeMode, and Visible; Boolean values without quotation marks; statements running in order; comments and indentation; closing the form; and syntax-error diagnosis.

- Choose a supported image format such as PNG or JPEG.
- Save All before testing.
- Use IntelliSense suggestions, but read what they insert.
- If two statements set the same property, the later assignment wins.
- If Visual Studio reports build errors and offers to run the last successful build, choose **No** and fix the errors. Running an old build does not test your changes.
- Check spelling/capitalization, semicolons, straight quotes, and matching opening/closing braces.
- Stop the running app before editing its layout.

## How the material fits together

| Source | Role in these practices |
| --- | --- |
| Earlier Card Flip textbook discussion: section 2.7, Tutorial 2-5, p. 97 | Base front/back PictureBox and two-button behavior |
| Saved September 9 class transcript, checked against its OWLL AI summary | Event-driven forms, properties, Boolean syntax, images, orderly statements, and debugging |
| Saved course naming notes and the existing Practice 06 guide | Prefixed camelCase and the setup → GUI → action → test → commit format |
| Our additional practice plan | Overlap and Flip-button extension; Name and Birthday theme with a date picker |

The live textbook reader's page content was blocked during preparation, so these guides do not claim a fresh complete reread of the book or all later recordings. The birthday exercise and optional age calculation are original practice. This companion paraphrases relevant teaching points; private recordings and personal study history are not included.
