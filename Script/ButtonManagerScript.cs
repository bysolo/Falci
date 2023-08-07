using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManagerScript : MonoBehaviour
{
    private static ButtonManagerScript instance;
    public static ButtonManagerScript Instance { get{ return instance; } }
    public GameObject NumberPanel, NumberssPanel, ColorPanel, DatePanel, DayPanel, StonePanel, FlowerPanel, AcitivityPanel, DoitNowPanel, MakePanel;
    public Text Numbertxt, Numbersstxt, ColorTxt, DateTxt, DayTxt, StoneTxt, FlowerTxt, ActivityTxt, DoitNowTxt, MakeTxt;



    [Header("Animations")]
    public Animation luckyNumberAnim, luckyNumbersAnim, luckyColorAnim, luckyDateAnim, luckyDayAnim, luckyStoneAnim, luckyFlowerAnim, dailyAnim, doItNowAnim, makeAwisnAnim;
    public Animation NumberClose, NumberssClose, ColorClose, DateClose, DayClose, StoneClose, FlowerClose, DailyClose, DoitNowClose, MakeClose;
    public Text btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10;
    public Button LuckyNumberbtn, LuckyNumberssbtn, LuckyColorbtn, Luckydatebtn, LuckyDaybtn, LuckyStonebtn, LuckyFlowerBtn, DailyActivitybtn, Doitnowbtn, MakeAwisnbtn;
    public string[] SonDegerler = new string[] { "", "", "", "", "", "", "", "", "", "" };
    

    public GameObject  üzgün, gülen;
    public GameObject luckyDayVideo, LuckyStoneVideo, LuckyFrowerVideo, DailyActivityVideo, DoitNowVideo, MakeAwisnVideo;

    void temizle(string buttontag)
    {
        PlayerPrefs.SetString(buttontag, "");
    }
    bool TarihFarkBul(string buttontag)
    {
        var SonKayit = Prefkaydert(false, buttontag);
        if (!System.String.IsNullOrEmpty(SonKayit))
        {
            var SonTiklamaTarihi = System.Convert.ToDateTime(SonKayit); //19:56
            var HedefZaman = SonTiklamaTarihi.AddHours(12); //19:57
            if (System.DateTime.Now > HedefZaman)
            {
                //12 Saat Gecmis
                //true

                Prefkaydert(true, buttontag, Deger: System.DateTime.Now.ToString());
                return true;
            }
            else
            {
                //12 Saat Henüz Geçmemis
                //false 

                return false;
            }
        }
        else
        {
            //İlk Kez Tikliyor
            Prefkaydert(true, buttontag, Deger: System.DateTime.Now.ToString());
            return true;
        }
    }
    string Prefkaydert(bool GetSet, string ButtonTag, string Deger = "")
    {
        
        if (GetSet)
        {
            PlayerPrefs.SetString(ButtonTag, Deger);
            return "KayitEtti";
        }
        else
        {
            return PlayerPrefs.GetString(ButtonTag, "");

        }
    }
    void SurekliYazdirici1()
    {
        string Tarih = PlayerPrefs.GetString("LuckyNumber", "");
        var SonTiklamaTarihi = System.Convert.ToDateTime(Tarih); //19:56
        var HedefZaman = SonTiklamaTarihi.AddHours(12); //19:57
        if (System.DateTime.Now > HedefZaman)
        {
            //12 Saat Gecmis
            //true
            try
            {
                btn1.text = "Lucky Number";
            }
            catch { }
        }
        else
        {
            //12 Saat Henüz Geçmemis
            //false 
            var KalanZaman = HedefZaman - System.DateTime.Now;
            btn1.text = "Lucky Number: " + KalanZaman.Hours.ToString()+":"+KalanZaman.Minutes.ToString()+":"+KalanZaman.Seconds.ToString();

        }
    }

    void SurekliYazdirici2()
    {
        string Tarih = PlayerPrefs.GetString("LuckyNumberss", "");
        var SonTiklamaTarihi = System.Convert.ToDateTime(Tarih); //19:56
        var HedefZaman = SonTiklamaTarihi.AddHours(12); //19:57
        if (System.DateTime.Now > HedefZaman)
        {
            //12 Saat Gecmis
            //true
            try
            {
                btn2.text = "Lucky Numbers";
            }
            catch { }
        }
        else
        {
            //12 Saat Henüz Geçmemis
            //false 
            var KalanZaman = HedefZaman - System.DateTime.Now;
            btn2.text ="Lucky Numbers: "+ KalanZaman.Hours.ToString() + ":" + KalanZaman.Minutes.ToString() + ":" + KalanZaman.Seconds.ToString();

        }
    }
    void SurekliYazdirici3()
    {
        string Tarih = PlayerPrefs.GetString("LuckyColor", "");
        var SonTiklamaTarihi = System.Convert.ToDateTime(Tarih); //19:56
        var HedefZaman = SonTiklamaTarihi.AddHours(12); //19:57
        if (System.DateTime.Now > HedefZaman)
        {
            //12 Saat Gecmis
            //true
            try
            {
                btn3.text = "Lucky Color";
            }
            catch { }
        }
        else
        {
            //12 Saat Henüz Geçmemis
            //false 
            var KalanZaman = HedefZaman - System.DateTime.Now;
            btn3.text = "Lucky Color: " + KalanZaman.Hours.ToString() + ":" + KalanZaman.Minutes.ToString() + ":" + KalanZaman.Seconds.ToString();

        }
    }
    void SurekliYazdirici4()
    {
        string Tarih = PlayerPrefs.GetString("LuckyDate", "");
        var SonTiklamaTarihi = System.Convert.ToDateTime(Tarih); //19:56
        var HedefZaman = SonTiklamaTarihi.AddHours(12); //19:57
        if (System.DateTime.Now > HedefZaman)
        {
            //12 Saat Gecmis
            //true
            try
            {
                btn4.text = "Lucky Date";
            }
            catch { }
        }
        else
        {
            //12 Saat Henüz Geçmemis
            //false 
            var KalanZaman = HedefZaman - System.DateTime.Now;
            btn4.text = "Lucky Date: " + KalanZaman.Hours.ToString() + ":" + KalanZaman.Minutes.ToString() + ":" + KalanZaman.Seconds.ToString();

        }
    }
    void SurekliYazdirici5()
    {
        string Tarih = PlayerPrefs.GetString("LuckyDay", "");
        var SonTiklamaTarihi = System.Convert.ToDateTime(Tarih); //19:56
        var HedefZaman = SonTiklamaTarihi.AddHours(12); //19:57
        if (System.DateTime.Now > HedefZaman)
        {
            //12 Saat Gecmis
            //true
            try
            {
                btn5.text = "Lucky Day";
            }
            catch { }
        }
        else
        {
            //12 Saat Henüz Geçmemis
            //false 
            var KalanZaman = HedefZaman - System.DateTime.Now;
            btn5.text = "Lucky Day: " + KalanZaman.Hours.ToString() + ":" + KalanZaman.Minutes.ToString() + ":" + KalanZaman.Seconds.ToString();

        }
    }
    void SurekliYazdirici6()
    {
        string Tarih = PlayerPrefs.GetString("LuckyStone", "");
        var SonTiklamaTarihi = System.Convert.ToDateTime(Tarih); //19:56
        var HedefZaman = SonTiklamaTarihi.AddHours(12); //19:57
        if (System.DateTime.Now > HedefZaman)
        {
            //12 Saat Gecmis
            //true
            try
            {
                btn6.text = "Lucky Stone";
            }
            catch { }
        }
        else
        {
            //12 Saat Henüz Geçmemis
            //false 
            var KalanZaman = HedefZaman - System.DateTime.Now;
            btn6.text = "Lucky Stone: " + KalanZaman.Hours.ToString() + ":" + KalanZaman.Minutes.ToString() + ":" + KalanZaman.Seconds.ToString();

        }
    }
    void SurekliYazdirici7()
    {
        string Tarih = PlayerPrefs.GetString("LuckyFlower", "");
        var SonTiklamaTarihi = System.Convert.ToDateTime(Tarih); //19:56
        var HedefZaman = SonTiklamaTarihi.AddHours(12); //19:57
        if (System.DateTime.Now > HedefZaman)
        {
            //12 Saat Gecmis
            //true
            try
            {
                btn7.text = "Lucky Flower";
            }
            catch { }
        }
        else
        {
            //12 Saat Henüz Geçmemis
            //false 
            var KalanZaman = HedefZaman - System.DateTime.Now;
            btn7.text = "Lucky Flower: " + KalanZaman.Hours.ToString() + ":" + KalanZaman.Minutes.ToString() + ":" + KalanZaman.Seconds.ToString();

        }
    }
    void SurekliYazdirici8()
    {
        string Tarih = PlayerPrefs.GetString("DailyActivity", "");
        var SonTiklamaTarihi = System.Convert.ToDateTime(Tarih); //19:56
        var HedefZaman = SonTiklamaTarihi.AddHours(12); //19:57
        if (System.DateTime.Now > HedefZaman)
        {
            //12 Saat Gecmis
            //true
            try
            {
                btn8.text = "Daily Activity";
            }
            catch { }
        }
        else
        {
            //12 Saat Henüz Geçmemis
            //false 
            var KalanZaman = HedefZaman - System.DateTime.Now;
            btn8.text = "Daily Activity: " + KalanZaman.Hours.ToString() + ":" + KalanZaman.Minutes.ToString() + ":" + KalanZaman.Seconds.ToString();

        }
    }
    void SurekliYazdirici9()
    {
        string Tarih = PlayerPrefs.GetString("DoitNow", "");
        var SonTiklamaTarihi = System.Convert.ToDateTime(Tarih); //19:56
        var HedefZaman = SonTiklamaTarihi.AddHours(12); //19:57
        if (System.DateTime.Now > HedefZaman)
        {
            //12 Saat Gecmis
            //true
            try
            {
                btn9.text = "Do it Now";
            }
            catch { }
        }
        else
        {
            //12 Saat Henüz Geçmemis
            //false 
            var KalanZaman = HedefZaman - System.DateTime.Now;
            btn9.text = "Do it Now: " + KalanZaman.Hours.ToString() + ":" + KalanZaman.Minutes.ToString() + ":" + KalanZaman.Seconds.ToString();

        }
    }
    void SurekliYazdirici10()
    {
        string Tarih = PlayerPrefs.GetString("MakeAwisn", "");
        var SonTiklamaTarihi = System.Convert.ToDateTime(Tarih); //19:56
        var HedefZaman = SonTiklamaTarihi.AddHours(12); //19:57
        if (System.DateTime.Now > HedefZaman)
        {
            //12 Saat Gecmis
            //true
            try
            {
                btn10.text = "Make a Wish";
            }
            catch { }
        }
        else
        {
            //12 Saat Henüz Geçmemis
            //false 
            var KalanZaman = HedefZaman - System.DateTime.Now;
            btn10.text = "Make a Wish: " + KalanZaman.Hours.ToString() + ":" + KalanZaman.Minutes.ToString() + ":" + KalanZaman.Seconds.ToString();

        }
    }



    //********************************************************************************************
    public void LuckyNumber()
    {
        if (TarihFarkBul("LuckyNumber"))
        {
            NumberPanel.SetActive(true);
            luckyNumberAnim.GetComponent<Animation>().Play("LuckyNumberAnim");
            Numbertxt.text = Random.Range(0, 99).ToString();
            InvokeRepeating("SurekliYazdirici1", 0, 1);
        }
        else
        {
            InvokeRepeating("SurekliYazdirici1", 0, 1);
        }
        
    }
    public void LuckyNumberss()
    {
        if (TarihFarkBul("LuckyNumberss"))
        {
            NumberssPanel.SetActive(true);
            luckyNumbersAnim.GetComponent<Animation>().Play("LuckyNumberAnim");
            Numbersstxt.text=Random.Range(0, 99).ToString() + "-" + Random.Range(0, 99).ToString() + "-" + Random.Range(0, 99).ToString() + "-" + Random.Range(0, 99).ToString() + "-" + Random.Range(0, 99).ToString() + "-" + Random.Range(0, 99).ToString();
            InvokeRepeating("SurekliYazdirici2", 0, 1);
        }
        else
        {
            InvokeRepeating("SurekliYazdirici2", 0, 1);
        }
       
    }
    public void LuckyColor()
    {
        if (TarihFarkBul("LuckyColor"))
        {
            ColorPanel.SetActive(true);
            luckyColorAnim.GetComponent<Animation>().Play("LuckyNumberAnim");
            ColorTxt.text = Colordizi[Random.Range(0, Colordizi.Length)];
            InvokeRepeating("SurekliYazdirici3", 0, 1);
        }
        else
        {
            InvokeRepeating("SurekliYazdirici3", 0, 1);
        }

        
    }
    public void LuckyDate()
    {
        if (TarihFarkBul("LuckyDate"))
        {
            DatePanel.SetActive(true);
            luckyDateAnim.GetComponent<Animation>().Play("LuckyNumberAnim");
            System.Random rn = new System.Random();
            var uretilensayi = rn.Next(1, 365);
            DateTxt.text = System.DateTime.Now.AddDays(uretilensayi).ToString("MM/dd/yyyy");
            InvokeRepeating("SurekliYazdirici4", 0, 1);
        }
        else
        {
            InvokeRepeating("SurekliYazdirici4", 0, 1);
        }
    }
    public void LuckyDay()
    {
        if (TarihFarkBul("LuckyDay"))
        {
            DayPanel.SetActive(true);
            luckyDayAnim.GetComponent<Animation>().Play("LuckyNumberAnim");
            ReklamScritp.Instance.ShowAd();
            DayTxt.text = Daydizi[Random.Range(0, Daydizi.Length)];
            
            
        }
        else
        {
            InvokeRepeating("SurekliYazdirici5", 0, 1); ;
        }

        
    }
    public void LuckyStone()
    {
        if (TarihFarkBul("LuckyStone"))
        {
            StonePanel.SetActive(true);
            luckyStoneAnim.GetComponent<Animation>().Play("LuckyNumberAnim");
            ReklamScritp.Instance.ShowAd();
            StoneTxt.text = StoneDizi[Random.Range(0, StoneDizi.Length)];
            
            
        }
        else
        {
            InvokeRepeating("SurekliYazdirici6", 0, 1);
            
        }

        
        
        
    }
    
    public void LuckyFlower()
    {
        if (TarihFarkBul("LuckyFlower"))
        {
            FlowerPanel.SetActive(true);
            luckyFlowerAnim.GetComponent<Animation>().Play("LuckyNumberAnim");
            ReklamScritp.Instance.ShowAd();
            FlowerTxt.text = FlowerDizi[Random.Range(0, FlowerDizi.Length)];
            InvokeRepeating("SurekliYazdirici7", 0, 1);
        }
        else
        {
            InvokeRepeating("SurekliYazdirici7", 0, 1);
            
           
        }
    }
    public void DailyActivity()
    {
        if (TarihFarkBul("DailyActivity"))
        {
            AcitivityPanel.SetActive(true);
            dailyAnim.GetComponent<Animation>().Play("LuckyNumberAnim");
            ReklamScritp.Instance.ShowAd();
            ActivityTxt.text = ActivityDizi[Random.Range(0, ActivityDizi.Length)];
          
        }
        else
        {
            InvokeRepeating("SurekliYazdirici8", 0, 1);

        }

        
    }
    public void DoitNow()
    {
        if (TarihFarkBul("DoitNow"))
        {
            DoitNowPanel.SetActive(true);
            doItNowAnim.GetComponent<Animation>().Play("LuckyNumberAnim");
            ReklamScritp.Instance.ShowAd();
            DoitNowTxt.text = DoItNowDizi[Random.Range(0, DoItNowDizi.Length)];
            

        }
        else
        {
            InvokeRepeating("SurekliYazdirici9", 0, 1);
            
        }
    }
    public void MakeAwisn()
    {
        if (TarihFarkBul("MakeAwisn"))
        {
            
            MakePanel.SetActive(true);
            makeAwisnAnim.GetComponent<Animation>().Play("LuckyNumberAnim");
            ReklamScritp.Instance.ShowAd();
            

            MakeTxt.text = Random.Range(1, 2).ToString();
            if (MakeTxt.text == "1")
            {
                gülen.SetActive(true);
            }
            else
            {
                gülen.SetActive(false);
            }
            if (MakeTxt.text == "2")
            {
                üzgün.SetActive(true);
            }
            else
            {
                üzgün.SetActive(false);
            }

            
        }
        else
        {
            InvokeRepeating("SurekliYazdirici10", 0, 1);
            
        }

    }

    string[] Colordizi = new string[] {
       "Light blue",
"Light purple",
"Outdoor turquoise",
"Light green",
"Light green",
"Light green yellow",
"Flame red",
"Flame Tournace",
"Alice blue",
"Alizarin color",
"Altunî",
"Amethyst color",
"Pear color",
"Aquamarine color",
"Army Green",
"Copper tone",
"Barut color",
"Swampy green",
"Baby blue",
"Beige",
"White",
"Bondi blue",
"Claret red",
"Bronze color",
"Wheat color",
"Burgundy",
"Aqua",
"Cyan blue",
"Pine green",
"Tea green",
"Steel blue",
"Chocolate color",
"Indigo color",
"sea",
"Sea green",
"Thistle color",
"Fern green",
"Electric blue",
"Electric green",
"Electric indigo color",
"Electric lime color",
"Electric purple color",
"Falu red",
"Ivory color",
"French rose color",
"Fuchsia",
"Night blue",
"Sky blue",
"Gray",
"Gray-asparagus",
"Rose color",
"Silvery",
"Khaki",
"Haki",
"Mustard color",
"Carrot color",
"Rooster color",
"Spring green",
"Islamic green",
"Pumpkin color",
"Brown",
"Brownish gray",
"Camouflage green",
"Carnation pink",
"Carnation color",
"Cardinal color",
"Karolina blue",
"Apricot",
"Amber color",
"Chestnut color",
"Linen color",
"Red",
"Reddish brown",
"Red-violet",
"Cherry red",
"Cobalt color",
"Cobalt blue",
"In darkness",
"Dark khaki",
"Dark brown",
"Dark chestnut",
"Dark red",
"Dark reddish brown",
"Dark lilac",
"Dark magenta",
"Dark mandarin",
"Dark blue",
"Dark violet",
"Dark coral",
"Dark purple",
"Dark pastel green",
"Dark pink",
"Dark peach",
"Dark powder blue",
"Dark turquoise",
"Dark green",
"Leather color",
"the Kremreng",
"Sand brown",
"Asparagus color",
"Navy blue",
"Lavender color",
"Lavender blue",
"Lavender pink",
"Lavender grisi",
"In lavender galibarda",
"Lavender pink",
"Lavender purple",
"Lavender rose color",
"Lemony",
"Light Lemon",
"Lilac color",
"Lime rengi",
"Mandarin color",
"Malachite color",
"Blue",
"Violet color",
"Violet color",
"Violet-eggplant color",
"Corn color",
"Purple",
"Muscle color",
"Mint greenery [1]",
"Pomegranate color",
"Navajo white",
"School Bus Warmer",
"Orchid color",
"Forest green",
"Magenta",
"Rust color",
"Pastel pink",
"Pastel green",
"Eggplant color",
"Pink",
"Pink-orange",
"Prophet's flower color",
"Prussian blue",
"Saffron color",
"Sapphire color",
"Yellowish brown",
"Yellowish pink",
"Yellow",
"Black",
"Blackish dark brown",
"Pale yellow",
"Peach color",
"Peach-orange",
"Peach-yellow",
"Cinnamon color",
"Teal",
"Powder blue",
"turquoise",
"Orange (web)",
"Orange yellow",
"Green",
"Green-yellow",
"Yonca green",
"Seaweed green",
"Zeytuni",
"Emerald",
"Burn orange",
"Burned soil color",
"Cardinal",
"Wine color",
"Celadon",
"Clear blue",
"sky blue",
"Rose color",
"Coral",
"Coral Red",
"Crimson",
"Cheat blue",
"the Altınıms",
"Clown",
"Wart",
"Holivod red",
"Hot Magenta",
"Hot pink",
"International Klein blue",
"International orange",
"Yesim",
"Medium wine",
"Middle Purple",
"Mountain pink",
"Vaccine coloring",
"Old gold",
"Old thread",
"Old Lavender",
"Old rose",
"Olive Brown",
"Orange",
"Frost orange",
"Papaya",
"Periwinkle",
"Persian blue",
"Persian greens",
"Persian blue",
"Persian",
"Persian red",
"Persian rose",
"Raw soil",
"Red egg blue",
"Royal blue",
"Red wine",
"Red",
"Sea",
"Discrete yellow",
"Strong pink",
"Brine grisi",
"Tenné Tawny",
"Small black",
"Navy blue",
"Viridian",
"Zinnwaldit to",

    };
    string[] StoneDizi = new string[] {
        "Agate",
"Aquamarine",
"Malachite",
"Tourmaline",
"Carnelian",
"Amazonite",
"Rose Quartz",
"Emerald",
"Cat's Eye",
"Emerald",
"Amethyst",
"Red Jasper",
"Tourmaline",
"Sodali",
"Garnet",
"Aventurine",
"Citrine",
"Smokey Quartz",
"Amethyst",
"Hematite",
"Citrine",
"Hematite",
"Crystal",
"Hematite",
"Tourmalated quartz",
"Red Jasper"

    };
    string[] Daydizi = new string[] {
        "Monday",
"Tuesday",
"Wednesday",
"Thursday",
"Friday",
"Saturday",
"Sunday"
    };

    string[] FlowerDizi = new string[] {
        "Aster",
"Azalea",
"Baby’s Breath",
"Gypsophila",
"Begonia",
"Bell Flower",
"American bellflower",
"Codonopsis",
"Chinese bellflower",
"Campanula",
"Bergamot",
"Bee Balm",
"Scarlet Beebalm",
"Scarlet Monarda",
"Oswego Tea",
"Crimson Beebalm",
"Monarda didyma",
"Bird of Paradise",
"Strelitzia",
"Bluebell",
"Hyacinthoides non-scripta",
"Bottlebrush",
"Callistemon",
"Buttercup",
"Ranunculus",
"Camellia",
"Carnation",
"Dianthus caryophyllus",
"Cherry Blossom",
"Sakura",
"Chrysanths",
"Chrysantemum",
"Golden Daisy",
"Chrysanthemum",
"Columbine",
"Aquilegia",
"Clover",
"Crocus",
"Daisy",
"Bellis perennis",
"Dahlia",
"Daffodil",
"Narcissus",
"Delphinium",
"Edelweiss",
"Leontopodium alpinum",
"Primrose",
"Primulaceae",
"Forget Me Not",
"Myosotis",
"Foxglove",
"Digitalis",
"Freesia",
"Gerbera",
"Gerbera Daisies",
"Gladiolus",
"Gladiolus",
"Hibiscus",
"Hibiscus",
"Heather",
"Erica",
"Hyacinth",
"Hyacinthus",
"Holly",
"Iris",
"Jasmine",
"Lady’s Slipper",
"Cypripedioideae",
"Lavender",
"Lilac",
"Syringa",
"Lily",
"Lilium",
"Water Lily",
"Lotus Flower",
"Nelumbo",
"Marigold",
"Tagetes",
"Marjoram",
"Mimosa",
"Narcissus",
"Orange Blossom",
"Choisya",
"Orchid",
"Orchidaceae",
"Peach Blossom",
"Peony",
"Peony",
"Petunia",
"Rhododendron",
"Rosemary",
"Roses",
"Sage",
"Salvia",
"Snapdragon",
"Antirrhinum",
"Sunflower",
"Helianthus annuus",
"Tansy",
"Thistle",
"Thyme",
"Tulip",
"Violets",
"Viola",
"Water Lily",
"Nymphaea Odorata",
"Zinnia"
    };

    string[] ActivityDizi = new string[] {
        "Do sport.",
"Jump the rope.",
"Get on the horse.",
"Go to the cinema.",
"Go to the dance.",
"Eat meat.",
"Eat vegetables.",
"Eat a salad.",
"Go to the theater.",
"Go to the cinema with your mother.",
"Walk with your mother.",
"Walk around the park with your mother.",
"Eat with your mother.",
"Go to the theater with your mother.",
"Chat with your mother.",
"Go to the cinema with your dad.",
"Step out with your father.",
"Walk around the park with your dad.",
"Eat with your dad.",
"Chat with your dad.",
"Go to the theater with your dad.",
"Go to the cinema with your sister.",
"Take a walk with your sister.",
"Walk in the park with your sister.",
"Eat dinner with your sister.",
"Chat with your sister.",
"Go to the theater with your sister.",
"Go to the cinema with your brother.",
"Take a walk with your brother.",
"Go in the park with your brother.",
"Eat dinner with your brother.",
"Go to the theater with your brother.",
"Chat with your brother.",
"Eat chicken.",
"Eat fish.",
"Eat meatballs.",
"Eat pizza.",
"Take a walk.",
"Go around the park.",
"Go to the zoo.",
"Watering the garden.",
"Tree addition.",
"Visit the animal shelter.",
"Get on the run.",
"Go to the pool.",
"Do the shopping.",
"Eat the pasta.",
"Listen to music.",
"Go to the concert.",
"Go talk show.",
"Watch the old movie.",
"Documentary Watch.",
"Read a book.",
"Go to the restaurant.",
"Start the art.",
"Make it sweet.",
"Make a model.",
"Make a puzzle.",
"Go fishing.",
"Get on the boat tour.",
"Play ball.",
"Play Table Tennis.",
"Play tennis.",
"Go to the game.",
"Carpet field match.",
"Go to the fun.",
"Play the guitar.",
"Play the violin.",
"Camping"
    };


    string[] DoItNowDizi = new string[] {
        "Roll over.",
"Call your best friend.",
"Kiss your favorite person.",
"Help somebody.",
"Shake your hand.",
"Laugh.",
"Eyebrow eyebrow.",
"Call your mother.",
"Kiss your mother.",
"Hug the mother.",
"Tell your mother you love her.",
"Take your mother a present.",
"Take your mother flowers.",
"Call your father.",
"Kiss your dad.",
"Tell your father you love him.",
"Get your father a present.",
"Take your father flowers.",
"Daddy hug.",
"Call your sister.",
"Kiss your sister.",
"Hug your sister.",
"Tell your sister you love her.",
"Get your sister a present.",
"Get your sister flowers.",
"Call your brother.",
"Kiss your brother.",
"Hold your brother.",
"Tell your brother you love him.",
"Get your brother a gift.",
"Get your brother flowers.",
"Drink water",
"Drink the cola.",
"Drink soda.",
"Drink the fruit.",
"Laugh.",
"Smile.",
"Raise your right hand.",
"Raise your left hand.",
"Lift your right foot.",
"Lift your left foot.",
"Jump.",
"Whistle.",
"Shouted.",
"Drink milk.",
"Make dog fake.",
"Fake the cat.",
"Fake the bird.",
"Make fish imitation.",
"Fake dead.",
"Sit down.",
"Get on the bus.",
"Get on the train.",
"Get in the hood.",
"Get in the metro.",
"Run through the stairs.",
"Run.",
"Make an eagle.",
"Sit on the table.",
"Get on your chair.",
"Show your toungue.",
"Bookmark and Share",
"Enter Instagrama.",
"Enter Facebook.",
"Send a twitt.",
"Send a message.",
"Turn off the phone.",
"Shake your head.",
"Breathe in your nose.",
"Turn around.",
"The shoes come out.",
"Take off your glasses.",
"Kiss your favorite friend.",
"Get a gift for your favorite friend.",
"Call your favorite friend.",
"Buy your favorite flower from your friend.",
"Shake your head.",
"Lift your eyebrows.",
"Laugh your eyebrows.",
"Remove the right eyebrow.",
"Remove the left eyebrow.",
"Scream."

    };

    /*string[] DateDizi = new string[] {
        "00:00",
        "00:15",
        "00:30",
        "00:45",
        "01:00",
        "01:15",
        "01:30",
        "01:45",
        "02:00",
        "02:15",
        "02:30",
        "02:45",
        "03:00",
        "03:15",
        "03:30",
        "03:45",
        "04:00",
        "04:15",
        "04:30",
        "04:45",
        "05:00",
        "05:15",
        "05:30",
        "05:45",
        "06:00",
        "06:15",
        "06:30",
        "06:45",
        "07:00",
        "07:15",
        "07:30",
        "07:45",
        "08:00",
        "08:15",
        "08:30",
        "08:45",
        "09:00",
        "09:15",
        "09:30",
        "09:45",
        "10:00",
        "10:15",
        "10:30",
        "10:45",
        "11:00",
        "11:15",
        "11:30",
        "11:45",
        "12:00",
        "12:15",
        "12:30",
        "12:45",
        "13:00",
        "13:15",
        "13:30",
        "13:45",
        "14:00",
        "14:15",
        "14:30",
        "14:45",
        "15:00",
        "15:15",
        "15:30",
        "15:45",
        "16:00",
        "16:15",
        "16:30",
        "16:45",
        "17:00",
        "17:15",
        "17:30",
        "17:45",
        "18:00",
        "18:15",
        "18:30",
        "18:45",
        "19:00",
        "19:15",
        "19:30",
        "19:45",
        "20:00",
        "20:15",
        "20:30",
        "20:45",
        "21:00",
        "21:15",
        "21:30",
        "21:45",
        "22:00",
        "22:15",
        "22:30",
        "22:45",
        "23:00",
        "23:15",
        "23:30",
        "23:45",

    };*/
    //class RandomDateTime
    //{
    //    System.DateTime start;
    //    System.Random gen;
    //    int range;

    //    public RandomDateTime()
    //    {
    //        start = System.DateTime.Now.AddYears(1);
    //        gen = new System.Random();
    //        range = (System.DateTime.Today - start).Days;
    //    }

    //    public System.DateTime Next()
    //    {
    //        return start.AddDays(gen.Next(range)).AddHours(gen.Next(0, 24)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60));
    //    }
    //}

    public void NumberExit()
    {
        NumberClose.GetComponent<Animation>().Play("ClosePanelAnim");
        StartCoroutine(PanelinKaybolusu1());
    }
    public void NumberssExit()
    {
        NumberssClose.GetComponent<Animation>().Play("ClosePanelAnim");
        StartCoroutine(PanelinKaybolusu2());
    }
    public void ColorExit()
    {
        ColorClose.GetComponent<Animation>().Play("ClosePanelAnim");
        StartCoroutine(PanelinKaybolusu3());
    }
    public void DateExit()
    {
        DateClose.GetComponent<Animation>().Play("ClosePanelAnim");
        StartCoroutine(PanelinKaybolusu4());
    }
    public void DayExit()
    {
        DayClose.GetComponent<Animation>().Play("ClosePanelAnim");
        StartCoroutine(PanelinKaybolusu5());
    }
    public void StoneExit()
    {
       StoneClose.GetComponent<Animation>().Play("ClosePanelAnim");
        StartCoroutine(PanelinKaybolusu6());
    }
    public void FlowerExit()
    {
        FlowerClose.GetComponent<Animation>().Play("ClosePanelAnim");
        StartCoroutine(PanelinKaybolusu7());
    }
    public void ActivityExit()
    {
        DailyClose.GetComponent<Animation>().Play("ClosePanelAnim");
        StartCoroutine(PanelinKaybolusu8());
    }
    public void DoitNowExit()    
    {
        DoitNowClose.GetComponent<Animation>().Play("ClosePanelAnim");
        StartCoroutine(PanelinKaybolusu9());
    }
    public void MakeExit()
    {
        MakeClose.GetComponent<Animation>().Play("ClosePanelAnim");
        StartCoroutine(PanelinKaybolusu10());
    }


    void Start()
    {
        instance = this;
        btn1.text = "Lucky Number";
        btn2.text = "Lucky Numbers";
        btn3.text = "Lucky Color";
        btn4.text = "Lucky Date";
        btn5.text = "Lucky Day";
        btn6.text = "Lucky Stone";
        btn7.text = "Lucky Flower";
        btn8.text = "Daily Activity";
        btn9.text = "Do It Now";
        btn10.text = "Make a Wish";
    }


    void Update()
    {

    }
  public IEnumerator PanelinKaybolusu1()
    {
        yield return new WaitForSeconds(1);
        NumberPanel.SetActive(false);
    }
    public IEnumerator PanelinKaybolusu2()
    {
        yield return new WaitForSeconds(1);
        NumberssPanel.SetActive(false);
    }
    public IEnumerator PanelinKaybolusu3()
    {
        yield return new WaitForSeconds(1);
        ColorPanel.SetActive(false);
    }
    public IEnumerator PanelinKaybolusu4()
    {
        yield return new WaitForSeconds(1);
        DatePanel.SetActive(false);
    }
    public IEnumerator PanelinKaybolusu5()
    {
        yield return new WaitForSeconds(1);
        DayPanel.SetActive(false);
    }
    public IEnumerator PanelinKaybolusu6()
    {
        yield return new WaitForSeconds(1);
        StonePanel.SetActive(false);
    }
    public IEnumerator PanelinKaybolusu7()
    {
        yield return new WaitForSeconds(1);
        FlowerPanel.SetActive(false);
    }
    public IEnumerator PanelinKaybolusu8()
    {
        yield return new WaitForSeconds(1);
        AcitivityPanel.SetActive(false);
    }
    public IEnumerator PanelinKaybolusu9()
    {
        yield return new WaitForSeconds(1);
        DoitNowPanel.SetActive(false);
    }
    public IEnumerator PanelinKaybolusu10()
    {
        yield return new WaitForSeconds(1);
        MakePanel.SetActive(false);
    }
}
