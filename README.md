# Practice 07 — Card Flip

Guided, ungraded C# Windows Forms practice. Start with two buttons that show the front and back of a card, then add one button that flips between the two.

The base exercise was identified in our earlier study discussion as *Starting Out with Visual C#*, 6th edition, section 2.7, Tutorial 2-5, beginning on printed page 97. The instructions below are an original practice guide. The single-button extension follows our practice plan. It is not a claim that the textbook includes that extension.

## Naming map

| Book name recovered from the earlier lesson | Name used here |
| --- | --- |
| cardBackPictureBox | picCardBack |
| cardFacePictureBox | picCardFace |
| showBackButton | btnShowBack |
| showFaceButton | btnShowFace |
| Our Flip extension | btnFlip |

Use the right-hand column everywhere in this practice.

## Part 1 — Setup

1. On this repository page, click **Code** and copy the HTTPS clone address.
2. In Visual Studio, choose **Clone a repository**, paste it, and select **Clone**.
3. If you see a folder view, double-click the `.sln` file.
4. In Solution Explorer, right-click **Form1.cs** and choose **View Designer**.
5. Press **F5** once. A blank form is expected. Close the running form before editing.
6. Open **View > Toolbox** to add controls. Select a control and press **F4** for Properties.
7. Use **(Name)** for the identifier used in code; use **Text** for visible wording.
8. Save everything with **Ctrl+Shift+S**.

Use Windows with Visual Studio and the **.NET desktop development** workload and .NET 10 SDK. These are blank WinForms starter projects: you place the controls and write each event handler while practicing. No completed solution is included.

On a computer where you already cloned this repository, open that existing solution and use **Git > Pull** before making new edits. If you have uncommitted edits, save and review them first; ask for help if Git reports a conflict.


## Part 2 — Prepare the pictures

1. In File Explorer, open the cloned repository folder.
2. Open `Assets/Make-Card-Images.html` in Edge or Chrome by double-clicking the local file. On GitHub the HTML appears as source; use the local cloned file.
3. Click **Save card back** and **Save card face**.
4. Move the two downloaded PNG files into this repository's `Assets` folder.
5. These are original simple practice cards, so you do not need to download the textbook's images. The previously identified textbook images were `Backface_Blue.jpg` and `Ace_Spades.jpg`.

## Part 3 — Create the GUI

Select the form itself first. Set its **Text** to `Card Flip`. Add these controls in the Designer. Keep their names exactly as shown throughout your code.

| Control | (Name) | Text / key settings |
| --- | --- | --- |
| PictureBox | picCardBack | SizeMode: Zoom; Size: 150, 210; Visible: True |
| PictureBox | picCardFace | SizeMode: Zoom; Size: 150, 210; Visible: False |
| Button | btnShowBack | Show Back |
| Button | btnShowFace | Show Face |

1. Initially put the PictureBoxes **side by side**, so you can select each easily.
2. Select the back PictureBox. In Properties, select **Image**, click **...**, and import `card-back.png` as a project resource.
3. Repeat for the face PictureBox with `card-face.png`.
4. Place the buttons below the pictures.
5. Save All. Run once and check that only the back image is visible.
6. Close the running form. Commit and push: `Create Card Flip layout and import images`.

## Part 4 — Write and test the actions

1. Double-click **Show Face** in the Designer to create its Click handler.
2. Inside that handler, make the face PictureBox's **Visible** property true and the back PictureBox's **Visible** property false.
3. Return to the Designer and double-click **Show Back**.
4. In that handler, make the back visible and the face hidden.
5. Use the exact PictureBox identifiers from the table. Boolean values are `true` and `false` with no quotation marks.
6. Save All and run. Try Show Face, Show Back, Show Back again, then Show Face again.
7. Check that exactly one picture is visible after every click.
8. Close the form. Commit and push: `Add Show Face and Show Back behavior`.

**Explain before continuing:** Which object is the button? Which objects are the PictureBoxes? What event starts the work? Which property changes?

## Part 5 — Overlay the pictures

1. Stop the running app and return to the Designer.
2. Use **View > Other Windows > Document Outline** if a PictureBox is hard to select.
3. Verify both PictureBoxes are children of **Form1**, at the same indentation in Document Outline. Do not drop one inside the other.
4. Select each PictureBox and enter the same **Location** through Properties, for example `40, 30`. Enter the same **Size** for each as well.
5. Run the app and test both buttons. The card should now change in one place.

Changing Location in Properties avoids accidentally re-parenting one PictureBox by dragging it onto the other. Designer appearance alone does not establish runtime visibility; test with F5.

## Part 6 — Add a single Flip button

1. Add another Button below the card.
2. Set **(Name)** to `btnFlip` and **Text** to `Flip`.
3. Double-click it to create its Click handler.
4. Write the logic in your own words first: if the face is currently visible, show the back; otherwise show the face.
5. Use the face PictureBox's **Visible** value as the current state. Each branch must show one image and hide the other.
6. Ask your tutor to introduce `if/else` if you have not covered it yet. This extension goes beyond the two original show buttons.
7. Test six consecutive Flip clicks. Then test Show Face → Flip and Show Back → Flip.
8. Stop, Save All, commit and push: `Overlay the pictures and add Flip`.

## Completion checklist

- [ ] I placed the controls and imported both pictures myself.
- [ ] Show Face and Show Back work, including repeated clicks.
- [ ] Both PictureBoxes occupy the same position and have Form1 as their parent.
- [ ] Flip changes the visible side on every click.
- [ ] I can explain Visible, true/false, and the Click event.
- [ ] I saved, committed, pushed, and can see my changes on GitHub.

Starter files were checked structurally; Windows build/run must be checked in Visual Studio. Preparation of this repository does not mean the exercise is completed.

## If stuck

See [Syntax and controls](SYNTAX-AND-CONTROLS.md). Stop at the first error and compare the exact control name and property. Work through one action at a time with your tutor.
