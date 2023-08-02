
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

            int z = Convert.ToInt32(x); // string olan x degiskenini convert yardimiyla integer a cevirdik

            char ab = 'c';
            int abc = Convert.ToInt32(ab); // bir chari integera cevirebiliriz buna char - int casting denir . O harfe karsilik gelen sayi kodunu verir

            Console.WriteLine((int)'f'); // bu sekilde de cast yapabiliriz bize direkt olarak f harfine karsilik gelen sayi kodunu verir 
            #endregion

        }
    }
}