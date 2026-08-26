using System.IO;
class Domek
{
    int szerokosc = 23;
    int wysokosc_dachu = 12;
    int wysokosc_sciany = 9;
    FileStream F;
    public void domek()
    {
        //dach
        F = new FileStream("dom.txt", FileMode.Create);
        for (int i = 0; i < wysokosc_dachu; i++)
        {
            for (int j = 0; j < szerokosc; j++)
            {
                if (j >= szerokosc / 2 - i && j <= szerokosc / 2 + i)
                {
                    F.WriteByte((byte)'X');
                }
                else
                {
                    F.WriteByte((byte)' ');
                }

            }
            F.WriteByte((byte)'\n');
        }
        //sciany
        for (int i = 0; i < wysokosc_sciany; i++)
        {
            for (int j = 0; j < szerokosc; j++)
            {
                if (j == 0 || j == szerokosc - 1)
                {
                    F.WriteByte((byte)'X');
                } // lewe okno
                else if ((i == 2 || i == 5) && (j >= 3 && j <= 7))
                {
                    F.WriteByte((byte)'X');
                } else if ((j==3 || j==7)&& (i>=2 && i <= 5))
                {
                    F.WriteByte((byte)'X');
                }// prawe okno
               
                else if((i == 2 || i == 5) && (j >= 15 && j <= 19))
                    {
                    F.WriteByte((byte)'X');
                    }
               else if ((j == 15 || j  == 19)&&(i>=2 && i<=5))
                {
                    F.WriteByte((byte)'X'); 

                } // drzwi
                else if((i >= 4 && i <= 8) && (j >= 9 && j <= 13))
                {
                    F.WriteByte((byte)'X');
                } //podloga
                else if( i == wysokosc_sciany - 1 )
                {
                    F.WriteByte((byte)'X');
                }
                else
                {
                    F.WriteByte((byte)' ');
                }
            }
            F.WriteByte((byte)'\n');

        }
        F.Close();
        F = new FileStream("dom.txt", FileMode.Open);
        F.Seek(288, SeekOrigin.Begin);
        for(int i = 0; i < 8; i++)
        { 
            
            for (int j = 0; j < 23; j++)
            {
                char znak = (char)F.ReadByte();
                if (j >= 3 && j <= 19)
                {
                    Console.Write(znak);
                }
            }
            F.ReadByte();
            Console.WriteLine();
        }
        
        F.Close();
    }
    static void Main(string[] args)
    {
        Domek domek = new Domek();
        domek.domek();

    }
}
       



                



            

