using System;
using System.IO;
namespace ClassLibrary1
{
    public class FileManagement
    {

        public static void FileStuff()


        {


            //STREAMWRITING: HOW TO WRITE TO A FILE

            // var file = File.Create(@"C:\Users\ofoezie ezichi fav\Desktop\CSHARP\night class\file\Example.txt");
            // System.Console.WriteLine(file.CanRead);
            //System.Console.WriteLine(file.CanWrite);
            //System.Console.WriteLine(file.Name);

            //................................
            //for each time you use File.Create, you must always recreate all your text. therefore you need a method. so that you can always write new things to an existing file
            // var file = File.Create(@"C:\Users\ofoezie ezichi fav\Desktop\CSHARP\night class\file\Example.txt");
            //file.WriteLine("heeello world");
            //file.WriteLine("heeello world");
            //file.WriteLine("heeello world");
            //file.Write("heeello world");
            // file.Dispose();


            //THIS WILL HELP YOUR FILE NOT TO BE OVERWRITTEN

            //if (!File.Create(path));
            // {
            //   File.Create(path)
            //}
            //var file = File.AppendText(path);
            //file.WriteLine("heeello world");
            //file.WriteLine("heeello world");
            //file.WriteLine("heeello world");
            //file.Write("heeello world");
            // file.Dispose();

            //fileStream
            //StreamReader
            //StreamWriter

            //CreateText opens the streamwriter





            //USING A METHOD INSTEAD OF FILE.CREATE.
            //here, it will not need to wipe the content of the file before adding a new text


            string path =@"C:\Users\ofoezie ezichi fav\Desktop\CSHARP\night class\file\Example.txt";
            // THE USING STATEMENTS HELPS YOU NOT TO NEED DISPOSE AGAIN "Using {}. also note that if you dont want to use var, use a streamwriter or streamreader as the case may be            if (!File.Exists(path))
           // {
               // using var ff = File.CreateText(path);
               // var ff = File.CreateText(path);
               //ff.Close();
           // } 


            //this is the using block
            using (var file = File.AppendText(path))    //you can also write using(StreamWriter streamWriter =  File.AppendText(path))


            {
               // var file = File.AppendText(path);
                file.WriteLine("CONGRATS ZICHIS, YOU FINALLY LEARNT, HOW TO CREATE A FILE");    //you can also write this here //StreamWriter.WriteLine("heello n welcome")
               // file.WriteLine("......................................");
               // this comment is checking if i will have broken lines before the next read
                file.WriteLine("Hello World");
                file.WriteLine("THANK YOU JESUS");
                file.Dispose();

            }
            using (StreamReader streamReader = File.OpenText(path))
            {
                                                                                                //readline and readtoend methods
                                                                                                //readline reads the first line
                                                                                                //readtoend helps us read the whole file or lines

                                                                                                //.........................................
                                                                                                //System.Console.WriteLine(streamReader.ReadToEnd());
                
                
                
                
                                                                                                 // var read = streamReader.ReadToEnd();
                                                                                                 //System.Console.WriteLine(streamReader.ReadToEnd());

                var read = streamReader.ReadToEnd();

                                                                                                 // TRIM TO END HELPS TO TRIM AND READ TO END
                read = read.TrimEnd();    //trim to end before splitting to avoid errors.
                var users = read.Split(Environment.NewLine);          //newline will give you a new split string
                                                                                                 //var last = users[^1];

                foreach (var item in users)
                {

                                                                                                    //USE THIS IDEA FOR THE TASK
                    var user = item.Split(',');
                    System.Console.WriteLine(user[0]);

                }








            }





        }
    }
}
