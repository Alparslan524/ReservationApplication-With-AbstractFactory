# Abstract Factory ile Rezervasyon Uygulaması

## Proje Amacı
Bir seyahat acentesinin rezervasyon modelinin [UML](https://raw.githubusercontent.com/Alparslan524/ReservationApplication-With-AbstractFactory/main/EkranGoruntuleri//IlkHali.png) diyagramı gösterilmiştir. Bu acentede rezervasyonlar ulaşım ve konaklama olarak beraber yapılmaktadır. Sistem bu haliyle sadece uçak ve otel rezervasyonu yapmaktadır. Fakat acente yönetimi işlerini genişletme kararı vermiştir ve farklı ulaşım ve konaklama opsiyonları sunmak istemektedir. Bu opsiyonlar şu şekilde olacaktır: Otobüs-Otel, Uçak-Otel, Otobüs-Çadır ve Uçak-Çadır. Ek olarak ilerleyen dönemlerde bu opsiyonlarda çeşit artışı olacağı göz önünde bulundurulması istenmektedir. Bu nedenle C# ve SQL kullanarak güvenilir, sade, kullanışlı ve Abstract Factory tasarım desenine uygun seyahat rezervasyon uygulaması yapılmıştır.
*** 

## Program Akışı
1. Programda müşteri seyahat edeceği aracı ve barınacağı yeri seçerek rezervasyon alır.
2. Alınan rezervasyon SQL veri tabanında güven ile tutulur 
3. Programda 4 farklı seçenek vardır. Bunlar otel-uçak, otel-otobüs, uçak-çadır, uçak-oteldir. 
Bu 4 seçeneğe yeni fonksiyonlar ekleme esnekliği sağlamak için Abstract Faktory tasarım deseni kullanılmıştır.
4. Projede oluşturulan rezervasyonlar XML, HTML ve JSON formatları halinde rapor edilebilmektedir.
***

## Uygulamadan Ekran görüntüleri
1. [UML Diyagramı](https://raw.githubusercontent.com/Alparslan524/ReservationApplication-With-AbstractFactory/main/EkranGoruntuleri/UML.png)
2. [Rezervasyon Ekranı](https://raw.githubusercontent.com/Alparslan524/ReservationApplication-With-AbstractFactory/main/EkranGoruntuleri/Giris.png)
3. [Json Rapor Örneği](https://raw.githubusercontent.com/Alparslan524/ReservationApplication-With-AbstractFactory/main/EkranGoruntuleri/JSonRapor.png)
4. [Xml Rapor Örneği](https://raw.githubusercontent.com/Alparslan524/ReservationApplication-With-AbstractFactory/main/EkranGoruntuleri/XMLRapor.png)
***
## Kullanılan Diller
* C#
## Kullanılan Veritabanı
* MsSQL
***


# Alparslan Aydoğan
- [GitHub](https://github.com/Alparslan524)
- [Linkedin](https://www.linkedin.com/in/alparslan-aydoğan-6038771bb/)
***
