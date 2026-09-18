namespace CardFlip;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnCardB_Click(object sender, EventArgs e)
    {
        picCardB.Visible = true;//SHOW BACK click makes backside visible
        picCardF.Visible = false;//SHOW BACK click makes face invisible
    }

    private void btnCardF_Click(object sender, EventArgs e)
    {
        picCardB.Visible = false;//SHOW FACE click hides backside visibility
        picCardF.Visible = true;//SHOW FACE click reveals face of card
    }

    private void btnFlip_Click(object sender, EventArgs e)
    {
        picCardF.Visible = !picCardF.Visible;//********chatgpt told me how to do this alternating, i tried on my own,**********
        picCardB.Visible = !picCardB.Visible;//********but i was doing:
                                             //********"picCardF.Image = picCardB.image
                                             //********"picCardB.Image = picCardF.Image"  
                                             //********this only allowed me to show face, because the last statement overwrote the above statement********
    }
}
        //<summary> I was actualy able to guess to use .visible...... i assumed from windowbox.show example.,
        //but i uploaded the .PNG from the assests on github, not sure how to get png straight from google<summary/>

        
 