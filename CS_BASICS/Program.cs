
namespace CsTemelleri
{
    class CsTemelleriIlkDers
    {
        public void Main (string[] arg) 
        {
            #region DegiskenTanimlama
            string Ad; //degisken tanimladik
                       // "pasa" cift tirnak ile tanimliysa stringdir
                       // 'p' tek tirnak ile tanimliysa char dir 
            #endregion
            #region DegiskenDegerAtama
            string Ad1 = "pasa"; //degiskeni tanimladik ve deger atadik ayni satirda
            string Ad2;
            Ad2 = "ismihan"; // degiskeni tanimladik fakat deger atamasini ayrica yaptik  
            #endregion
            #region var Tipi
            var a = "pasa";
            var b = 123; // dinamik bir tip oldugu icin atama yaptigimiz degerin tipini aliyor 
            #endregion
            #region object Tipi
            object C = " ";
            object D = 123; // object tipine degisken tanimi yapildiginda ve bir deger atandiginda kutuya atilmis dusuncesi vardir .  Buna boxing denir . artik bu degerin tipi objecttir
            int unboxingD = (int)D; // boxing olan bir degiskeni unboxing yaptik yani kutudan cikarip tipini belirledik .
            #endregion
            #region Tip Donusumleri
            string x = "123";
            int y = x; // bu hatali bir cevirmedir , string olan bir tipi int e bu sekilde ceviremeyiz.

            int z = Convert.ToInt32(x); // string olan x degiskenini convert yardimiyla integer a cevirdik.

            char ab = 'c';
            int abc = Convert.ToInt32(ab); // bir chari integera cevirebiliriz buna char - int casting denir . O harfe karsilik gelen sayi kodunu verir
            //ssds
            Console.WriteLine((int)'f'); // bu sekilde de cast yapabiliriz bize direkt olarak f harfine karsilik gelen sayi kodunu verir 
            #endregion
            #region SwitchCase
            int p = 10;
            switch (p)
            {
                case 5:
                    //......
                    break;
                case 10:
                    Console.WriteLine("degerimiz 10dur");
                    break;
            }
            #endregion
            #region break continue return
            //break => break komutu switch case ve dongulerde kullanilir sadece icinde bulundugu donguden cikar ornegin ic ice 2 dongumuz var icerideki dongude break kullanirsak disaridakini etkilemez
            //for (int i = 0; i < max; i++)
            //{
            //    for (int i = 0; i < max; i++)
            //    {
            //        break;
            //    }
            //}

            //continue => kendinden sonraki satirlari etkisiz hale getirir onlarin okunmasini engeller , dongu icerisinde kullanilirsa continue olan kisim atlanir sonrakinden devam eder

            //return => icerisinde bulundugu metotdan cikarir (break sadece donguden cikariyordu) ornegin Main metodu icerisinde kullanirsak direkt main metodundan cikarir 

            #endregion
            #region Array 
            // diziler olusturulurken eleman sayisini vermek zorundayiz
            // ornek dizi int[] Yaslar = new int[25]  
            // string[] isimler = new string[25]
            //DEGER ATAMA:
            //Yaslar[3] = 18;
            //DEGER OKUMA:
            //Console.Writeline(Yaslar[3])
            //deger atamadigimiz bir indexi okumak istedigimizde 0 cevabini aliriz
            /*dizinin elemanlarini donguye sokmak icin ; 
             for(int i=0;i<Yaslar.length;i++)
            {Yaslar[i] = i*2
            Console.WriteLine(Yaslar[i])}*/
            // dizileri gostermenin farkli yollari vardir , ustte dizinin eleman sayisini direkt olarak belli ediyorduk fakat asagidaki ornekte elemanlari tanimlarken gosteriyoruz ve eleman sayisini yazmiyoruz
            // int[] Yas2 = new int[] {3,5,6,1,2,3,56,3,2} bu sekilde suslu parantez ile direkt olarak dizinin elemanlarini onden tanitabiliriz
            // int[] Yas3 = {3,5,2,4,6,8}
            // int[] Yas4 = new int[3] {5,6,7} bu ornekler gibi de kullanabiliriz .
            //degisiklikler yapildi
            #endregion

        }
    }
}