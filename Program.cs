string [] array ={"ab","gf","bg","abc","abcd","abcde","del","hz","123"};


string j= string.Empty;
int n =0;
    for (int i=0;i<array.Length ; i++)
        {
             j=array[i];
                
            if (j.Length<=3)
                { 
                    n++;
                }
        }
string [] temp = new string [n];
int k=0;
for (int i=0;i<array.Length ; i++)
        {
             j=array[i];
                
            if (j.Length<=3)
                {
                    temp[k]=j;
                    k++;
                }
        }
        for (int i=0; i<temp.Length;i++)
        {
            Console.WriteLine (temp[i]);
        }