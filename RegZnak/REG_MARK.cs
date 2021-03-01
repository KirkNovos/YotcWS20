using System;
using System.Linq;

namespace RegZnak
{
    public class REG_MARK
    {

        public class Mark_info
        {
            
        }


        public Boolean CheckMark(string mark)
        {
            int ti;
            string num1 = (mark.Substring(0, 1));
            string num2 = (mark.Substring(4, 2));
            string dig1 = (mark.Substring(1, 3));
            string dig2 = (mark.Substring(6, 3));
            bool isDig1 = int.TryParse(dig1, out ti);
            bool isDig2 = int.TryParse(dig2, out ti);


            if (char.IsLetter(num1[0]))
            {
                for (int i=0; i<num2.Length; i++)
                {
                    if (char.IsLetter(num2[i]))
                    {
                        if (isDig1)
                        {
                            if (isDig2)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public string GetNextMarkAfter(string mark)
        {
            char [] AlphaList = Enumerable.Range('a','z' - 'a'+1).Select(c=>(Char)c).ToArray();
            string AL = new string(AlphaList);
            //string AlphaList = { abcdefghijklmnopqrstuvwxyz };
            string num1 = (mark.Substring(0, 1));
            string num2 = (mark.Substring(4, 2));
            string dig1 = (mark.Substring(1, 3));
            string dig2 = (mark.Substring(6, 3));


            string subnum1 = (num2.Substring(1, 1));
            string subnum0 = (num2.Substring(0, 1));

            int dg1 = Convert.ToInt32(dig1);
            int dg2 = Convert.ToInt32(dig2);

            char nnum1;
            char nnum2;

            //var indexOfStringValue;
            int at = AL.IndexOf(num1);
            

            if (dg1 == 999 && dg2 == 999)
            {
                at = at + 1;
                nnum1 = AlphaList[at];

                string nnnum1 = Convert.ToString(nnum1);
                dig1 = "001";


                if (subnum1 == "z")
                {
                    int bt = AL.IndexOf(subnum0);
                    bt = bt + 1;

                    nnum2 = AlphaList[bt];
                    string nnnum2 = Convert.ToString(nnum2);
                    dig2 = "001";
                    subnum1 = "a";

                    return nnnum1 + dig1 + nnnum2 + subnum1 + dig2;
                }
                else
                {
                    int bt = AL.IndexOf(subnum1);
                    bt = bt + 1;
                    nnum2 = AlphaList[bt];
                    string nnnum2 = Convert.ToString(nnum2);
                    dig2 = "001";

                    return nnnum1 + dig1 + subnum0 + nnnum2 + dig2;
                }

               

                

            }
            else
            {
                if (dg1 == 999)
                {
                    at = at + 1;
                    nnum1 = AlphaList[at];

                    string nnnum1 = Convert.ToString(nnum1);
                    dig1 = "001";

                    return nnnum1 + dig1 + num2 + dig2;
                }
                else if (dg2 == 999)
                {
                    if(subnum1 == "z")
                    {
                        int bt = AL.IndexOf(subnum0);
                        bt = bt + 1;
                        nnum2 = AlphaList[bt];

                        //num2[1] = "a"; 
                        string nnnum2 = Convert.ToString(nnum2);
                        dig2 = "001";
                        subnum1 = "a";

                        return num1 + dig1 + nnnum2 + subnum1 + dig2;
                    }
                    else
                    {
                        int bt = AL.IndexOf(subnum1);
                        bt = bt + 1;
                        nnum2 = AlphaList[bt];

                        string nnnum2 = Convert.ToString(nnum2);
                        dig2 = "001";

                        return num1 + dig1 + subnum0 +nnnum2 + dig2;
                    }

                    
                }
                else
                {
                    dg1 = dg1 + 1;
                    dig1 = Convert.ToString(dg1);
                    dg2 = dg2 + 1;
                    dig2 = Convert.ToString(dg2);

                    return num1 + dig1 + num2 + dig2;
                }
                    
                

            }

        }

    }
}
