# Holographic Grisons

Die Holographic Grisons App projiziert virtuelle Informationen auf ein physisch vorhandenes Bergmodell. Die Applikation läuft auf der Microsoft Hololens. Diese Projekt wurde im Rahmen des Major Media Applications an der HTW Chur und der BFH erstellt.

So bekommt der interessierte Benutzer beispielsweise ein Gefühl für die Beschaffenheit der Wanderwege und die Möglichkeiten vor Ort. Diese Informationen können an die eigene E-Mail Adresse versendet werden. 

https://github.com/pscllbssr/Holographic-Grisons/raw/master/docs/mmp_ma_hg_trigger.jpg

## Zugangsdaten

Sämtlicher Code für dieses Projekt ist auf Github gehostet.

[https://github.com/pscllbssr/Holographic-Grisons](https://github.com/pscllbssr/Holographic-Grisons)

## Konzeption & Testing

Um mehr über die Bedürfnisse der Benutzer herauszufinden, haben wir auf Papier Prototypen zurückgegriffen und diese spielerisch mit Probanden durchgetestet. Daraus haben wir folgende Erkenntnisse gezogen:

* pi 

* pa 

* pu

## Wireframes
Aus diesen Erkenntnissen haben wir Wireframes für unsere Applikation erstellt. Die Wireframes befinden sich unter  [Wireframes in Adobe Cloude](www.www.www)

## Verwendete Technologien

### Bergmodell

Unser Bergmodell haben wir von Hand aus Papier und Verpackungsmaterial erstellt. Es wurde zum Prototyping, Testing und zur Entwicklung verwendet.

### 3D Scanner

Um unsere virtuellen,interaktiven Elemente korrekt zu platzieren, benötigten wir ein virtuelles Abbild von unserem Bergmodell. Dazu verwendeten wir die App «bliblablu». Diese App erlaubt es, anhand von einem Video eine 3D-Objekt zu erstellen.

### Instant Mesh

Das erstellte Bergmodell hatte viel zu viele Polygone. Deshalb benutzten wir [Instant Meshes](https://github.com/wjakob/instant-meshes), um die Polygone zu reduzieren.

### Cinema 4D

In Cinema 4D haben wir die einzelnen 3D-Objekte für unsere Applikation modelliert.

### Unity

In der Entwicklungsumgebung Unity setzten wir die einzelnen Elemente zu einem ganzen, einer «Szene» zusammen. Die 3D-Objekte lassen sich importieren und im Raum platzieren. Die einzelnen Objekte werden mit Scripts versehen, um ihnen Funktionen und Interaktivität zu verleihen. Die gesamte Szene exportieren wir jeweils als Visual Studio Projekt.

### Microsoft Visual Studio

Das in Unity erstellte Projekt lässt sich in Microsoft Visual Studio importieren, um es anschliessend auf die Hololens zu übertragen. Dazu muss die Hololens einmalig konfiguriert werden, danach wird eine bestehende WLAN-Verbindung benötigt. In Visual Studio lässt sich die Applikation theoretisch debuggen. Der Debugger bricht aber teilweise an Stellen ab, die ohne Debugging in der Hololens funktionieren. 


## Technische Herausforderungen

### Entwicklungsumgebung für Hololens

Applikationen für die Hololens haben grundsätzlich eine grosse Hürde: Das Gerät ist teuer in der Anschaffung. Das macht es schon mal schwieriger zu entwickeln als andere AR/VR/MR-Apps für beispielsweise Smartphones. Wir hatten zum Glück eine Hololens zur Verfügung, mussten uns aber logistisch organisieren.

Zudem sind die Anforderungen an die Entwicklungs-Hardware zum Teil sehr strikt. Der Hololens-Emulator läuft beispielsweise nur mit Hyper-V, was Windwos 10 Professional voraussetzt.

Das Übertragen der Applikation von Unity über Visual Studio auf die Hololens nimmt jeweils mehrere Minuten in Anspruch, was den Entwicklungsprozess enorm ausbremst. Das austesten von kleinen Änderungen dauert so unnötig lange. Zudem kommt es immer mal wieder vor, dass die Übertragung auf die Hololens mit einer kryptischen Fehlermeldung abbricht. Zum Teil kann man die Übertragung noch einmal starten. Teilweise mussten wir aber auch einige Schritte zurück gehen damit es wieder funktionierte.

### Marker & Positionierung

In einem ersten Schritt wollten wir den Berg, respektive die zustäzlichen Infos via 3D-Objekterkennung anzeigen lassen. Das hätte uns einen zusätzlichen Marker erspart. Dafür haben wir auf [Vuforia](https://www.vuforia.com/) zurückgegriffen. 
Die 3D-Objekterkennung arbeitete jedoch nicht zuverlässig. Wir vermuten den Grund in den wechselnden Lichtverhältnissen. Aus diesem Grund haben wir einen 2D-Marker auf A4-Papier erstellt und ihn in einer bestimmten Position zum Berg positioniert.

Die Skalierung und Positionierung des 3D-Objekts auf den physische Modell war die nächste Herausforderung. Da die beiden Grössenmasse in keinem Verhältnis zueinander stehen, mussten wir schlussendlich solange an den Grössen drehen, bis wir ein zufriedenstellendes Ergebnis erhielten.

### Zu viele Polygone

Ein weiteres Problem waren die vielen Polygone. Am Anfang standen wir bei gesamthaft 142'000 Polygonen in der Applikation. Das haben wir auch in der Performance gemerkt. Die Applikation war entsprechend schwerfällig und der Cursor hinkte hinterher. Das lag vor allem an unserem Bergmodell, das wir mit der App in ein 3D-Modell umgewandelt hatten. Dank Instant Meshes und durch entfernen des Lichts in der Szene konnten wir diese Zahl erheblich verringern.

## Learnings

Hololens schwierig

## Potentielle Weiterentwicklung
Einige Punkte, mit denen diese Applikation weiterentwickelt werden könnte.

- Einbinden von Wetterdaten mit der entsprechenden Visualisierung
- Serialisierung des Objektimports, mit dem Ziel, beliebige Berge in die Applikation integrieren zu können. Das erfordert unter anderem eine Umrechnung von GPS-Daten in Unity-Koordinaten

[logo]: https://github.com/pscllbssr/Holographic-Grisons/raw/master/docs/mmp_ma_hg_trigger.jpg "Holographic Grisons"
