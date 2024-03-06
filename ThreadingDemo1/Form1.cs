namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem 1 çalıştı");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem 2 çalıştı");
        }

        /*
         * Windows form uygulamaları single-threaded uygulamalardır. Yani bu örnekteki gibi
         * bir butona tıkladığımızda açılan MessageBox'ı kapatmadan diğer butona ya da
         * formdaki herhangi bir yere tıklayamayız.
         * 
         * Tek threadi aquaparklardaki su kaydırağına benzetebiliriz.
         * Bir kişi kaydıraktan kayarken diğer kişi onu bekler.
         * Kaydıraktan kayan kişi çıktığında aşağıdaki cankurtaran düdüğüyle
         * yukarıdaki cankurtarana bu durumu bildirir ve yukarıda bekleyen kişi
         * kaydıraktan kaymaya başlar. Kaydıraktan kayan kişi çıkmadan diğer kişinin
         * kaymasına izin verilmez.
         * 
         * Multithreading'de ise birden fazla kişi farklı kaydıraklardan aynı anda kayıyor
         * gibi düşünülebilir. Ancak 2 Thread var ancak sistemde aynı anda 3 işlem yapılabiliyor
         * ise 3. işlemi yapan Thread, 1. ve 2. işlemi yapan Thread'lerin işlemlerini bekler.
         * Hangi Thread'in işlemi biterse 3. işlem işlemini bitiren Thread ile çalışmaya
         * başlar. Yani Multithreading'de de bir Thread'in diğer Thread'lerin işlemini
         * bekleyebildiği durumlar söz konusu olabilir.
         * - Çekirdek sayısına bağlı olarak sisteme yeni Thread eklenmesi bir düzeye kadar sistem
         * performansında artış sağlar. Ancak bir noktadan sonra performans azalmaya başlar.
         * Sistemler (IIS, Apache, Tomcat gibi) bu durumu yönetebilmek için optimum sayıda
         * eş zamanlı çalışabilen Thread Pool (Thread Havuzu) oluştururlar.
         * 
         * Asenkron programlamada ise tek Thread'de 2 birden fazla işlemi aynı anda yapabilmek
         * mümkündür. İşlemler zaman bağımsız (asenkron) olarak tek Thread'i paylaşarak
         * çalışabilirler. Böylece bir işlem diğer işlemin bitmesini beklemek zorunda kalmaz.
         * 
         * Sonuç olarak Asenkron programlamada da Multithreading'deki gibi birden fazla
         * işlemi aynı anda çalıştırabilmek mümkündür. Multithreading'den farkı ise bir Thread
         * birden fazla işlem için kullanılabilir. Bu sayede Thread Pool'daki Thread sayısından
         * fazla istek geldiğinde diğer isteklerin işlemleri bitene kadar beklemek yerine
         * herhangi bir Thread'i paylaşımlı olarak kullanarak isteklerin işlenmesini sağlar.
         * Bu sayede sistemde bir bekleme olmaz ve performans artar.
         */
    }
}
