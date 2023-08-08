
namespace CsTemelleri
{
    class CsTemelleriIlkDers
    {
        public static void Main(string[] arg)
        {
            #region DegiskenTanimlama
            string Ad; //degisken tanimladik
                       // "pasa" cift tirnak ile tanimliysa stringdir
                       // 'p' tek tirnak ile tanimliysa char dir 
            #endregion
            #region DegiskenDegerAtama
            //string Ad1 = "pasa"; //degiskeni tanimladik ve deger atadik ayni satirda
            //string Ad2;
            //Ad2 = "ismihan"; // degiskeni tanimladik fakat deger atamasini ayrica yaptik  
            #endregion
            #region var Tipi
            //var a = "pasa";
            //var b = 123; // dinamik bir tip oldugu icin atama yaptigimiz degerin tipini aliyor 
            #endregion
            #region object Tipi
            //object C = " ";
            //object D = 123; // object tipine degisken tanimi yapildiginda ve bir deger atandiginda kutuya atilmis dusuncesi vardir .  Buna boxing denir . artik bu degerin tipi objecttir
            //int unboxingD = (int)D; // boxing olan bir degiskeni unboxing yaptik yani kutudan cikarip tipini belirledik .
            #endregion
            #region Tip Donusumleri
            //string x = "123";
            //int y = x; // bu hatali bir cevirmedir , string olan bir tipi int e bu sekilde ceviremeyiz.

            //int z = Convert.ToInt32(x); // string olan x degiskenini convert yardimiyla integer a cevirdik.

            //char ab = 'c';
            //int abc = Convert.ToInt32(ab); // bir chari integera cevirebiliriz buna char - int casting denir . O harfe karsilik gelen sayi kodunu verir
            //ssds
            //Console.WriteLine((int)'f'); // bu sekilde de cast yapabiliriz bize direkt olarak f harfine karsilik gelen sayi kodunu verir 
            #endregion
            #region SwitchCase
            //int p = 10;
            //switch (p)
            //{
            //    case 5:
            //        //......
            //        break;
            //    case 10:
            //        Console.WriteLine("degerimiz 10dur");
            //        break;
            //}
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
            #region Diziler 
            // diziler olusturulurken eleman sayisini vermek zorundayiz
            // ornek dizi int[] Yaslar = new int[25]  
            // string[] isimler = new string[25]
            //DEGER ATAMA:
            //Yaslar[3] = 18;
            //DEGER OKUMA:
            //Console.Writeline(Yaslar[3])
            //deger atamadigimiz bir indexi okumak istedigimizde 0 cevabini aliriz
            //dizinin elemanlarini donguye sokmak icin ; 
            // for(int i=0;i<Yaslar.length;i++)
            // {Yaslar[i] = i*2
            // Console.WriteLine(Yaslar[i])}*/
            // dizileri gostermenin farkli yollari vardir , ustte dizinin eleman sayisini direkt olarak belli ediyorduk fakat asagidaki ornekte elemanlari tanimlarken gosteriyoruz ve eleman sayisini yazmiyoruz
            // int[] Yas2 = new int[] {3,5,6,1,2,3,56,3,2} bu sekilde suslu parantez ile direkt olarak dizinin elemanlarini onden tanitabiliriz
            // int[] Yas3 = {3,5,2,4,6,8}
            // int[] Yas4 = new int[3] {5,6,7} bu ornekler gibi de kullanabiliriz .
            //degisiklikler yapildi
            #endregion
            #region Array
            //Array.Clear metodu -> dizinin elemanlarinin degerlerini varsayilan yapar . Array.Clear(Sayilar,0,Sayilar.length) yaparsak Sayilar dizisinin her elemanini varsayilan olarak 0 yapar
            //Array.Copy metodu -> dizinin elemanlarini baska bir diziye kopyalar . Array.Copy(Sayilar, Sayilar2 , 3) yaparsak Sayilarin elemanlarindan ilk 3 unu Sayilar2 ye kopyalar
            //Array.IndexOf metodu -> elemanin indexini verir . Array.IndexOf(Sayilar,12) 12 sayisinin dizideki index numarasini bize dondurur . yoksa -1 doner
            //Array.Reverse metodu -> Array.Reverse(Sayilar)
            //Array.Sort metodu -> Array.Sort(Sayilar)
            #endregion
            #region foreach
            //foreach (int item in Sayilar)
            //{
            //    Console.WriteLine(item);
            //    Console.Read();
            //}   Bu sekilde donguye sokup dizideki elemanlari yazdirabiliriz , kulanisli bir metotdur 
            #endregion
            #region trycatch
            //errorlar 3 cesittir ;
            //compile error -> syntax hatalarinda ortaya cikar , projeyi ayaga kaldirinca hatayi goruruz
            //logical(mantiksal) error -> en ugrastirici hatadir program sorunsuz calisir fakat istenilen sonuclardan farklidir bu yuzden kodlari tek tek incelememiz gerekir
            //run time error -> program calisir ama program calisirken olusan hatalari listeler ornegin bir int girdigimizde sorunsuz calisir fakat bir string girince hata aliriz bu hata turunde TRY CATCH kullanabiliriz
            //try
            //{
            Console.WriteLine("lutfen bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi + " girdiginiz deger bir sayidir");
            Console.Read();
            //}
            //catch (Exception ex)
            //{
            //bu alandaki ex in getirdigi bazi ozellikler vardir ornegin Console.WriteLine(ex.message) dedigimizde bize sistemin belli hatalarda verdigi oto mesaji verir boylelikle ne hatasi yaptigimizi goruruz
            //}
            #endregion
            #region Classlar 
            //classlar icerisinde metotlari tanimlariz , ornegin Main bir metottur

            #endregion
            #region Metodlar
            //islem parcaciklari olarak dusunulebilir , yapacagimiz her islemi ayri ayri parcalara boldugumuzde bunlari ayri metodlar olarak yazabiliriz . Yontem olarak da gecer
            //Metodlari olustururken 4 adet tip vardir bunlara dikkat ederek olusturacagiz . Girdisi veya ciktisi var mi yok mu buna bakacagiz
            //Parametre aliyor mu almiyor mu , geriye deger gonderiyor mu gondermiyor mu buna bakacagiz bu durumda 4 farkli varyasyon ortaya cikiyor
            //ornek bir metod  ;
            //[erisim belirleyici(public mi private mi vs.)] [geri donus tipi(int,string)] [adi] {
            // islemler ...    }
            //! eger bir metod geriye deger gondermiyorsa void ile belirtiriz
            // public void Metod1 (bool x) {Console.WriteLine(x + "false" } console ile yazildiginda geriye deger gondermesi anlamina gelmez . bu ornek deger gondermeyen paramete alan metod ornegidir
            // private int Metod2 () {return 3;} geriye deger gonderen(int olarak gonderecegini belirttik)  parametre almayan metod tipi 

            #endregion
            #region MetodlarinKullanimi
            //     class program
            //{
            //    public static void Main(string[] arg)
            //    {
            //        int toplamSonuc = Topla(15, 23);
            //    }
            //    static public int Topla(int sayi1 , int sayi2)
            //    {
            //        double bolmeIslemi = Bolme(12, 4);
            //        return sayi1 + sayi2;
            //    }
            //    static public double Bolme(double sayi1,double sayi2)
            //    {
            //        return sayi1 / sayi2;
            //    }
            //} yukaridaki ornekte cikaracagimiz sonuc , biz ayni class icerisinde farkli metotlar kullanabiliriz ve bunlari birbiri icerisinde de kullabiliriz . fakat nihayetinde calistirmak icin main metodunu kullaniriz
            #endregion
            #region new keyword
            //objectler yani nesneler classlardan olusur , yani class(sinif) lar nesne uretmemizi saglayan yapilardir.
            // int string gibi turler de birer class tir
            // Ornek abc = new Ornek(); dedigimizde Ornek class dir , abc ise instance ve ayni zamanda referanstir , referans oldugu da nesnemiz yani Ornek() . bu dusuncede abc stack de tutulurken Ornek() onun heap inde tutulur
            // new Ornek() demek Ornek sinifindan bir nesne talep ettigimiz anlamina gelir

            #endregion
            #region Overload
            //ayni sinif icerisinde ayni isimde birden fazla metod yapabiliriz fakat parametre sayilari ayni olmamalidir veya parametre tipleri ayni olmamalidir veya parametre yerleri ayni olmamalidir  
            #endregion
            #region Field Property
            //Field degisken demetir class icerisinde olustururuz private int x ; bir field ornegidir .
            //main metodunda classa ulasmak icin bir object olusturuyoruz uzerinden Ornek o = new Ornek(); ile olusturduk . Ornek class i icerisinde bizim fieldimiz oldugu icin onu o.x seklinde cagirabiliriz
            //fakat bunu istemeyiz cunku kodlarimiza disaridan erisim olur , bunu engellemek icin de Property vardir get ve set  komutlari ile erisime acabiliriz
            // property ornegi ; public int X { get {} set{} } ilk basa erisim bigisi gelir sonrasinda ilgili fieldin turu(int) giirilir ve parantez acmadan suslu parantezler ile get set yazariz (parantez acsaydik metod olurdu)
            // public int X {get {return x; } set { x = value; } }
            // ornegin Main metodunda x fieldi ile islem yapmak istedigimizde o.x = "pasa" yazarsak set komutu calisir "pasa" yi value ye esitler , Console.WriteLine(o.x); dedigimizde ise get calisir ve fieldi cagirmis oluruz 
            #endregion
            #region Constructor
            //constructor . siniftan nesne olusturdugumuzda ( new Ornek();) o nesneyi yapilandirmamiza yariyor 
            //constructor metod public olmalidi
            //constructor metodun geri donus degeri olmaz
            //constructor metodun ismi class ismi ile ayni olmalidir
            // public Ornek () {} construnctor metod ornegidir
            // mesela int x; bir fieldimiz olsun ve public int X {get; set; }  ve biz constructor olarak public Ornek() { x = 15 } yazarsak buradaki amac main metodunda Ornek class i ile Ornek nesnesi ( new Ornek())
            // cagirildiginda otomatik olarak x 15 degerini alir cunku constructor ile yapilandirmis oluruz , nesne olusturulduktan sonra ilk calisacak metod constructor dir 
            #endregion
            #region Destructor 
            //uretilmis bir nesnenin bellekten silinme asamasinda son yapilacak islemi belirten metoddur , constructor ilk calisiyordu bu son calisiyor
            // ~Ornek () {Console.WriteLine("nesne siliniyor")} seklinde yazilir
            // Garbage Collector un kod yazim sekli GC.Collect(); seklindedir bu koddan sonraki referanssiz nesnelerin tamamini silecektir 
            #endregion
            #region this
            // this keywordu , ilgili sinifta turetilmis nesneleri sinif icerisinde temsil etmemizi saglayan bir keyworddur 
            #endregion
            #region ArrayList Collection
            //DIZILERIN OLUMSUZ YANLARI
            // Eleman sayisini onceden belirtmemiz gerekiyor
            // Elemanlari atmasak dahi bellekte yerleri ayriliyor
            // Performans acisindan zayif
            // Eleman atarken veya okurken kod maliyeti olusuyor

            // ArrayList Collections 
            // ArrayList de bir class dir .
            // ArrayList liste = new ArrayList(); seklinde yeni object tanimliyoruz fakat bunun icerigi bir ArrayList collection dur .
            // ArrayList de islem yapmak dizilerdeki gibi koseli parantezle degil komutlarla yapilir yani liste.Add() eleman eklemek icin kullandigimiz,  komutlardan bir tanesidir
            // ornek olarak ArrayListe eleman atmak istersek liste.Add("pasa")  liste.Add("ismihan") yazim sirasina gore listenin 0. indexi 1. indexi seklinde eleman atamis olduk . bunlari cagirmak icin de
            // yine indexer(yani [ ] ) kullanacagiz liste[1] ; cagirdigimizda bize "ismihan" sonucunu verecektir
            // ArrayList lerde biz eleman ekledigimizde bu eleman object turunde gelmektedir , fakat bu olumsuz bir seydir cunku boxing durumu olusur ve performans acisindan iyi degildir .
            // biz hangi tipi girdiysek ornegin string , listede de bunu string turunde gormek isteriz , bu olumsuz ozellikten dolayi ArrayList de pek kullanilmamaktadir 


            #endregion
            #region Generic List Collection

            #endregion
        }
    }
}