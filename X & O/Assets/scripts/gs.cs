
using UnityEngine;
using UnityEngine.UI;

public class gs : MonoBehaviour
{
    public Button b;
    public Text a;
    public string playside;
    public game g;
    public Button[] be;
    public int f=0;
    private string x="X";
    private string o = "O";

    public void ka()

    {
       
        a.text = playside;
        b.interactable = false;
    

    }
     void Update()
    {
       
            
                if (g.d == 1)
                {
                    playside = "X";
                    

                   
                }
                if (g.d == 2)
                {
                    playside = "O";
                   

                }
      


        if (g.b[0].text == x && g.b[1].text == x && g.b[2].text == x)
        {
            g.c.text = "X won";
            g.s.SetActive(true);

        }
        else if (g.b[0].text == o && g.b[1].text == o && g.b[2].text == o)
        {
            g.c.text = "O won";
            g.s.SetActive(true);
        }



        else if (g.b[3].text == x && g.b[4].text == x && g.b[5].text == x)
        {
            g.c.text = "X won";
            g.s.SetActive(true);

        }
        else if (g.b[3].text == o && g.b[4].text == o && g.b[5].text == o)
        {
            g.c.text = "O won";
            g.s.SetActive(true);
        }



        else if (g.b[6].text == x && g.b[7].text == x && g.b[8].text == x)
        {
            g.c.text = "X won";
            g.s.SetActive(true);

        }
         else if (g.b[6].text == o && g.b[7].text == o && g.b[8].text == o)
        {
            g.c.text = "O won";
            g.s.SetActive(true);
        }












       else if (g.b[0].text == x && g.b[3].text == x && g.b[6].text == x)
        {
            g.c.text = "X won";
            g.s.SetActive(true);

        }
      else  if (g.b[0].text == o && g.b[3].text == o && g.b[6].text == o)
        {
            g.c.text = "O won";
            g.s.SetActive(true);
        }



      else  if (g.b[1].text == x && g.b[4].text == x && g.b[7].text == x)
        {
            g.c.text = "X won";
            g.s.SetActive(true);

        }
       else if (g.b[1].text == o && g.b[4].text == o && g.b[7].text == o)
        {
            g.c.text = "O won";
            g.s.SetActive(true);
        }



      else  if (g.b[2].text == x && g.b[5].text == x && g.b[8].text == x)
        {
            g.c.text = "X won";
            g.s.SetActive(true);

        }
      else  if (g.b[2].text == o && g.b[5].text == o && g.b[8].text == o)
        {
            g.c.text = "O won";
            g.s.SetActive(true);
        }











       else if (g.b[0].text == x && g.b[4].text == x && g.b[8].text == x)
        {
            g.c.text = "X won";
            g.s.SetActive(true);

        }
       else if (g.b[0].text == o && g.b[4].text == o && g.b[8].text == o)
        {
            g.c.text = "O won";
            g.s.SetActive(true);
        }



       else if (g.b[2].text == x && g.b[4].text == x && g.b[6].text == x)
        {
            g.c.text = "X won";
            g.s.SetActive(true);

        }
       else if (g.b[2].text == o && g.b[4].text == o && g.b[6].text == o)
        {
            g.c.text = "O won";
            g.s.SetActive(true);
        }
        else
        {
            f = 4;
        }
            if(g.b[0].text!=""&& g.b[1].text != "" && g.b[2].text != "" && g.b[3].text != "" && g.b[4].text != "" && g.b[5].text != "" && g.b[6].text != "" && g.b[7].text != "" && g.b[8].text != "")
            {
            if (g.b[0].text == x && g.b[1].text == x && g.b[2].text == x)
            {
                g.c.text = "X won";
                g.s.SetActive(true);

            }
            else if (g.b[0].text == o && g.b[1].text == o && g.b[2].text == o)
            {
                g.c.text = "O won";
                g.s.SetActive(true);
            }



            else if (g.b[3].text == x && g.b[4].text == x && g.b[5].text == x)
            {
                g.c.text = "X won";
                g.s.SetActive(true);

            }
            else if (g.b[3].text == o && g.b[4].text == o && g.b[5].text == o)
            {
                g.c.text = "O won";
                g.s.SetActive(true);
            }



            else if (g.b[6].text == x && g.b[7].text == x && g.b[8].text == x)
            {
                g.c.text = "X won";
                g.s.SetActive(true);

            }
            else if (g.b[6].text == o && g.b[7].text == o && g.b[8].text == o)
            {
                g.c.text = "O won";
                g.s.SetActive(true);
            }












            else if (g.b[0].text == x && g.b[3].text == x && g.b[6].text == x)
            {
                g.c.text = "X won";
                g.s.SetActive(true);

            }
            else if (g.b[0].text == o && g.b[3].text == o && g.b[6].text == o)
            {
                g.c.text = "O won";
                g.s.SetActive(true);
            }



            else if (g.b[1].text == x && g.b[4].text == x && g.b[7].text == x)
            {
                g.c.text = "X won";
                g.s.SetActive(true);

            }
            else if (g.b[1].text == o && g.b[4].text == o && g.b[7].text == o)
            {
                g.c.text = "O won";
                g.s.SetActive(true);
            }



            else if (g.b[2].text == x && g.b[5].text == x && g.b[8].text == x)
            {
                g.c.text = "X won";
                g.s.SetActive(true);

            }
            else if (g.b[2].text == o && g.b[5].text == o && g.b[8].text == o)
            {
                g.c.text = "O won";
                g.s.SetActive(true);
            }











            else if (g.b[0].text == x && g.b[4].text == x && g.b[8].text == x)
            {
                g.c.text = "X won";
                g.s.SetActive(true);

            }
            else if (g.b[0].text == o && g.b[4].text == o && g.b[8].text == o)
            {
                g.c.text = "O won";
                g.s.SetActive(true);
            }



            else if (g.b[2].text == x && g.b[4].text == x && g.b[6].text == x)
            {
                g.c.text = "X won";
                g.s.SetActive(true);

            }
            else if (g.b[2].text == o && g.b[4].text == o && g.b[6].text == o)
            {
                g.c.text = "O won";
                g.s.SetActive(true);
            }
            else
            {
                g.c.text = "DRAW";
                g.s.SetActive(true);
            }

        }
       

    }
}
