
# Train-Ticket-Booking
Pristupni podaci/Acess info:

desktop/winforms: 

username : desktop

password : test

mobile/xamarinforms:

username : mobile

password : test


TEST DATA:

PRODANE KARTE:
Today date

PUTOVANJA
Today date +1 day, Today date +2 day , Today date +3 day

Implementirane su slijedeće funkcionalnosti

UI (Windows forms)
-	Prijava korisnika
-	Dodavanje novih korisnika
-	Pretraga korisnika 
-	Dodavanje novih putovanja
-	Izmjena podataka o putovanjima
-	Pretraga putovanja
-	Pregled dolaznih i odlaznih putovanja po stanicama
-	Pregled kupljenih karata
-	Kreiranje izvještaja
-	Pregled neprocesiranih rezervacija
-	Procesiranje rezervacija
- Loyality program (dodatna)
- Akcije na putovanja u odabranom periodu (dodatna)
- Prikaz top relacija - 5 najprometnijih ruta (dodatna)

Mobilna
-	Prijava kupca
-	Registracija kupca
-	Pretaga putovanja
-	Kupovina karata 
-	Upravljanje ličnim podacima
-	Pregled kupljenih karata kupca
-	Prikaz preporučenih putovanja 
- Notifikacija/Alert prilikom približavanja putovanja za kojeg je kupljena karta (dodatna)
- Obavještenja (dodatna)
- Ocjenjivanje putovanja koja su prošla (dodatna)
-	Popust na djecu prilikom kupovine karata (dodatna)
- Generički code karte (dodatna)
-	Payment servis - Stripe(dodatna)
-	Info (dodatna)



About
This project is made in C# using .NET Core and contains a WebAPI, Xamarin Forms app and a WinForms app for administration.

Entity Framework Core is used as an ORM, and the project also uses libraries like Swagger and AutoMapper.

VGFeed project was made as a part of a subject Software Development II on the Faculty of Information Technologies in Mostar. As such the naming used throughout the app for entities is in Bosnian and not in English.

The idea of the app is to be a type of social network for people that like video games with features such as :

Adding a list of the games a user has played
Adding a list of the games a user is interested in
Connecting with other users and messaging them
Adding user contact info for specific online game platforms and apps like Steam, PSN, Xbox Live, Discord etc
Rating the games a user has played which will in turn recommend similar games to the user and also recommend users with similar taste
Ability to track current ongoing Sales on all the most popular game platforms
A lot of these features were implemented as mock features, that is to say, this app doesn't utilize external APIs which would be used for a real-world version of this project and is more of a demonstration of things I've learned in C# and .NET Core framework.
