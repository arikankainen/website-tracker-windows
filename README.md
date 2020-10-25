# Website Tracker

Website Trackerilla voidaan tarkkailla kokonaisen nettisivun tai lähdekoodista määritellyn osan muutoksia. Tarkkailtavaksi voidaan laittaa esimerkiksi jonkin nettikaupan tietyn tuotteen pelkkä hinta, tai jonkin ohjelmiston versionumero, jolloin saadaan ilmoitus aina kun hinta muuttuu tai ohjelmasta julkaistaan uusi versio. Javascriptiä ohjelma ei tue, joten jos sivun sisältö tai tarkkailtava osa luodaan Javascriptillä, homma ei toimi.

![Website Tracker](/docs/main.png)

## Käyttö

Listalle voidaan lisätä kohteita, jotka tarkistetaan automaattisesti kohteessa määritellyn ajan välein. Listan kohteita voidaan poistaa käytöstä, tällöin `Enabled` -sarakkeessa lukee `No`. Kohteeseen voidaan määritellä tarkistuksen alkamis- ja päättymiskohta lähdekoodista, jolloin vain kyseisen kohdan muutokset sivussa otetaan huomioon tarkistuksessa. Alkamis- ja päättymiskohta näkyy `Content start` ja `Content stop` -sarakkeissa. `Result` -sarake näyttää alkamis- ja päättymiskohdan väliin jäävän tarkistettavan sisällön. `Checksum` -sarakkeen sisältö on tuon tarkistettavan sisällön laskennallinen tarkistussumma, jonka perusteella päätellään onko sisältö muuttunut vai ei. Omat sarakkeet on myös viimeiselle tarkistukselle (`Last checked`) ja viimeksi päivittyneelle (`Last updated`) sisällölle. `Status` -sarake kertoo jos tarkistuksessa on ongelmia. `Allow empty result` -sarake kertoo, sallitaanko tulokseksi tyhjä sisältö, vai päätyykö tyhjä sisältö virheeksi.

Oletuksena listalla päivittyneiden kohteiden väri on sininen, ja kohteen edessä on keltainen pallukka. Kohteiden fontti ja väri on muokattavissa. Päivittynyttä kohdetta tuplaklikkaamalla kohde avautuu selaimeen, ja se merkitään listaan `ei-päivittyneeksi`. Sama toiminto voidaan suorittaa valikosta tai napista, `List / Open selected page`. Kohde voidaan myös merkitä `ei-päivittyneeksi` valikosta tai napista `List / Clear `updated` status`.

Ikkunan tilapalkissa näkyy tilastotieto kuinka monta päivittynyttä kohdetta ja kuinka monta tarkistusvirheen sisältämää kohdetta, sekä kuinka monta käytössä olevaa tai käytöstä poistettua kohdetta listalla on. Tilapalkki sisältää myös viimeisimmän tarkistuksen ajankohdan.

## Valikot

Kaikki valikoista löytyvät ohjelman toiminnot on lueteltu alla. `List` -valikon toiminnot löytyy myös omina painikkeinaan työkalupalkista. `List` -valikko saadaan näkyviin myös listan kohdetta hiiren oikealla napilla painaen.

**_File / Exit_**\
Ohjelma voidaan sulkea tästä, mikä ohjelma on määritelty piiloutumaan tehtäväpalkin ilmoitusalueelle ikkunan sulkemispainikkeesta.

**_File / Backup, Restore_**\
Listatiedosto voidaan varmuuskopioida haluttuun tiedostoon tai palauttaa varmuuskopio käyttöön. Varmuuskopio on hyvä tehdä aika ajoin, ettei mahdollisen ohjelmavirheen sattuessa menetä vaivalla kerättyä listaa.

**_List / Check selected, Check all_**\
Tarkistetaan valittu kohde tai kaikki kohteet. Kohteita joissa automaattinen tarkistus on pois päältä (eli `Enabled` -kenttä on tyhjä), ei tarkisteta.

**_List / New, Modify, Delete_**\
Voidaan lisätä, muokata tai poistaa kohde listalta.

**_List / Enabled_**\
Kohde voidaan poistaa käytöstä tai ottaa käyttöön.

**_List / Clear 'updated' status_**\
Listan kohteet joissa sisältö on päivittynyt, näytetään oletuksena sinisellä ja rivin edessä on keltainen kuvake. Tällä valinnalla voidaan kuitata päivittynyt kohde katsotuksi.

**_List / Open selected page, Open all updated pages_**\
Avataan valittu päivittynyt kohde tai kaikki päivittyneet kohteet nettiselaimeen, ja kuitataan samalla päivittynyt kohde katsotuksi.

**_Settings / Remember window size, Remember window position_**\
Voidaan valita halutaanko että ikkunan koko ja/tai ikkunan sijainti muistetaan seuraavalla käynnistykerralla.

**_Settings / Remember column sizes, Remember column order_**\
Voidaan valita muistetaan sarakkeiden koko ja/tai sarakkeiden järjestys seuraavalla käynnistyskerralla.

**_Settings / Show notifications_**\
Valitaan näytetäänkö näytön oikeassa alakulmassa ilmoitus päivittyneistä sivuista.

**_Settings / Start automatically with Windows_**\
Valitaan käynnistyykö ohjelma automaattisesti Windowsia käynnistettäessä. Asetus tallentuu Windowsin rekisteriin.

**_Settings / Start minimized_**\
Käynnistetäänkö ohjelma pienennettynä.

**_Settings / Minimize to tray_**\
Pienennetäänkö ikkuna piiloon tehtäväpalkin ilmoitusaluelle.

**_Settings / Close to tray_**\
Ohjelma on mahdollista piilottaa tehtäväpalkin ilmoitusalueelle painamalla ikkunan sulkemispainiketta. Tällöin ohjelman voi oikeasti sulkea valitsemalla `File / Exit`.

**_Settings / Save log file_**\
Tallennetaan lokitiedostoa tarkistuksista. Lokitiedosto löytyy ohjelman kansiosta nimellä `check.log`.

**_Settings / Select web browser_**\
Voidaan valita päivittyneiden sivujen avaamiseen muu selain kuin Windowsin oletusselain.

**_Settings / Set font_**\
Voidaan valita fontti erikseen ei päivittyneille kohteille, päivittyneille kohteille, sekä kohteille jonka tarkistuksessa on tapahtunut virhe.

**_Settings / Set color_**\
Voidaan valita väri erikseen ei päivittyneille kohteille, päivittyneille kohteille, sekä kohteille jonka tarkistuksessa on tapahtunut virhe.

## Tarkkailtavan sivun lisäys

![Sivun lisäys](/docs/new.png)

Uusi tarkkailtava sivu voidaan lisätä valikosta `List / New`, tai painamalla työkalupalkin plus-kuvaketta. Alla selitetty ikkunan toiminnot.

**_Address, Name, Notes_**\
Tarkkailtavan nettisivun osoite, nimi ja mahdolliset lisätiedot.

**_Update content_**\
Haetaan osoitekenttään syötetyn osoitteen lähdekoodi. Jos nimikenttä on jätetty tyhjäksi, haetaan siihen samalla sivun nimi.

**_Filter content from the following text_**\
Lähdekoodin tarkkailtavaa kohtaa edeltävä kohta koodista. Näytetään punaisella lähdekoodissa.

**_To the following text_**\
Lähdekoodin tarkkailtavaa kohtaa seuraava kohta koodista. Näytetään punaisella lähdekoodissa.

**_Use selected text_**\
Lisätään kenttään lähdekoodi-ikkunassa valittuna oleva teksti.

**_Scroll to result_**\
Vieritetään lähdekoodi-ikkuna tarkkailtavaan kohtaan, mikäli kohta löytyy.

**_Allow empty result_**\
Sallitaan tarkkailtavaksi kohdaksi tyhjä merkkijono. Mikäli asetus ei ole päällä ja tarkistuksessa saadaan tyhjä tulos, se tulkitaan virheeksi ja tarkistusta yritetään uudelleen hetken päästä. Hyödyllinen joissain tapauksissa kun sivu ei aina lataudu oikein tai muusta syystä silloin tällöin palauttaa aiheettoman tyhjän tuloksen.

**_Page source_**\
Koko sivun lähdekoodi. Koodissa tarkkailtavaa kohtaa edeltävä ja seuraava kohta värjätään punaisella. Itse tarkkailtava kohta värjätään sinisellä.

**_Enable automatic checking_**\
Oletuksena sivu tarkistetaan 2 tunnin välein. Tarkistusvälin voi muuttaa tai tarkistuksen ottaa pois käytöstä.

**_Checksum_**\
Laskennallinen tarkistussumma tarkkailtavasta kohdasta. Edellisen tarkistuksen tarkistussummaa verrataan seuraavan tarkistuksen tarkistussummaan, ja jos ne eroavat, on sivussa tapahtunut muutos.

## Lataus

En ota mitään vastuuta ohjelman mahdollisesti aiheuttamista vahingoista; kukin käyttää ohjelmaa omalla vastuullaan. Vaatii Windows 7:n tai uudemman. Vaatimuksena myös .NET Framework 4.7, joka tulee ainakin Windows 10:n tapauksessa esiasennettuna.

**[Lataa uusin versio](https://github.com/arikankainen/website-tracker-windows/releases)**
