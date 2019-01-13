# Holographic Grisons

Die Holographic Grisons App projiziert virtuelle Informationen auf ein physisch vorhandenes Bergmodell. Die Applikation läuft auf der Microsoft Hololens. Dieses Projekt wurde im Rahmen des Major Media Applications an der HTW Chur und der BFH erstellt.

So bekommt der interessierte Benutzer beispielsweise ein Gefühl für die Beschaffenheit der Wanderwege und die Möglichkeiten vor Ort. Folgender Screencast zeigt die Ansicht der App durch die Microsoft Hololens:

[![IMAGE ALT TEXT HERE](https://img.youtube.com/vi/1v2P3WmzNYc/0.jpg)](https://www.youtube.com/watch?v=1v2P3WmzNYc)

## Zugangsdaten

Sämtlicher Code für dieses Projekt ist auf Github gehostet.

[https://github.com/pscllbssr/Holographic-Grisons](https://github.com/pscllbssr/Holographic-Grisons)

## Konzeption & Testing

Um mehr über die Bedürfnisse der Benutzer herauszufinden, haben wir auf Papier-Prototypen zurückgegriffen und diese spielerisch mit Probanden durchgetestet. Daraus haben wir folgende Erkenntnisse gezogen:

* AR-Brillen wie die Hololens sind noch nicht weit verbreitet und somit ist deren Anwendung für viele noch Neuland. Dies machte sich bereits bei den Tests mit den Papier-Prototypen bemerkbar. Die meisten Testpersonen blieben an einem Ort stehen und betrachteten die Szene, obschon die Hololens es ermöglichen würde, die Szene aus allen Blickwinkeln zu erkunden. Deshalb entschieden wir uns, die Wanderwege auch durch den Berg hindurch anzuzeigen, somit wird auf den ersten Blick ersichtlich, dass man sich um den Berg herum bewegen kann. 

* Zu viele Anzeigen auf einmal überforderten die Testpersonen. Es ist sinnvoll, möglichst wenige Informationen auf einmal anzuzeigen. Denn bereits die Art der Präsentation im Raum gibt dem Benutzer gewisse Informationen, welche nicht auch noch durch zuviele Anzeigen überstrapaziert werden sollten.

* Die Testpersonen hatten bereits viel Spass beim reinen Betrachten der Szene. Die Interaktion (nicht zuletzt wegen der ungewohnten Steuerung) wurde nur spärlich benutzt. Vielmehr wurde der Berg von allen Seiten erkundet, was ja bereits auch ohne eingeblendete Informationen einiges über die Begebenheiten des Wanderweges aussagt. 

* Schlichte Icons sind die besten Art, zusätzliche Informationen zum Wanderweg zu geben. Die Kombination aus Icons und deren Platzierung auf dem Berg geben dem Benutzer bereits sehr viele Informationen. 

[Fotos](https://drive.google.com/drive/folders/12c-4Y8_smpwGEnU9_Hl9006RraA3fHcI)
(Wir empfehlen die Foto-Links bei gedrückter «Cmd»- oder «Ctrl»-Taste zu öffnen)

## Wireframes
Aus diesen Erkenntnissen haben wir Wireframes für unsere Applikation erstellt. Die Wireframes befinden sich unter [Wireframes in Adobe Cloude](https://xd.adobe.com/view/3bf63f25-fb30-4e24-566e-ac24fb3eb550-4dc7/)

## Verwendete Technologien

### Bergmodell

Unser Bergmodell haben wir von Hand aus Papier und Verpackungsmaterial erstellt. Es wurde zum Prototyping, Testing und zur Entwicklung verwendet.

[Fotos](https://drive.google.com/drive/folders/1mScFqKRmoj0vNjyQnWDr-0oTH2uPbYxB)

### 3D Scanner

Um unsere virtuellen, interaktiven Elemente korrekt zu platzieren, benötigten wir ein virtuelles Abbild von unserem Bergmodell. Dazu verwendeten wir die App «3DF Zephyr». Diese App erlaubt es, anhand eines Videos ein 3D-Objekt zu erstellen.

[Foto](https://drive.google.com/file/d/1ZMz19D1GE1GGSOZwtw3tuiHxdXSqhjAF/view)

### Instant Mesh

Das erstellte Bergmodell hatte viel zu viele Polygone. Deshalb benutzten wir [Instant Meshes](https://github.com/wjakob/instant-meshes), um die Polygone zu reduzieren.

[Foto](https://drive.google.com/file/d/1OKlwQz9V8UymfM7sBHDi_xGtgvfggbZr/view) 

### Cinema 4D & Adobe Illustrator

In Cinema 4D haben wir die einzelnen 3D-Objekte für unsere Applikation modelliert. Als Grundlage für diese Modelle dienten Pfade der Objekte, die im Adobe Illustrator zuvor aufbereitet wurden.

[Fotos](https://drive.google.com/drive/folders/1ws_e80CpX_rt4oQJ5QC1RHIFTL5B7G6v) 

### Unity/C#

In der Entwicklungsumgebung Unity setzten wir die einzelnen Elemente zu einem ganzen, einer «Szene» zusammen. Die 3D-Objekte lassen sich importieren und im Raum platzieren. Die einzelnen Objekte werden mit Scripts (C#) versehen, um ihnen Funktionen und Interaktivität zu verleihen. Die gesamte Szene exportieren wir jeweils als Visual Studio Projekt.

[Fotos](https://drive.google.com/drive/folders/1iBkJvMmiwRVM7Dk9LR-u0XMBA8HA8hvu)

### Microsoft Visual Studio

Das in Unity erstellte Projekt lässt sich in Microsoft Visual Studio importieren, um es anschliessend auf die Hololens zu übertragen. Dazu muss die Hololens einmalig konfiguriert werden, danach wird eine bestehende WLAN-Verbindung benötigt. In Visual Studio lässt sich die Applikation theoretisch debuggen. Der Debugger bricht aber teilweise an Stellen ab, die ohne Debugging in der Hololens funktionieren.

[Fotos](https://drive.google.com/file/d/1uFvGLTio690VpV_w4jbUe7JQghB8_hUo/view)

## Technische Herausforderungen

### Entwicklungsumgebung für Hololens

Applikationen für die Hololens haben grundsätzlich eine grosse Hürde: Das Gerät ist teuer in der Anschaffung. Das macht es schon mal schwieriger zu entwickeln als andere AR/VR/MR-Apps für beispielsweise Smartphones. Wir hatten zum Glück eine Hololens zur Verfügung, mussten uns aber logistisch organisieren.

Zudem sind die Anforderungen an die Entwicklungs-Hardware zum Teil sehr strikt. Der Hololens-Emulator läuft beispielsweise nur mit Hyper-V, was Windwos 10 Professional voraussetzt.

Das Übertragen der Applikation von Unity über Visual Studio auf die Hololens nimmt jeweils mehrere Minuten in Anspruch, was den Entwicklungsprozess enorm ausbremst. Das Austesten von kleinen Änderungen dauert so unnötig lange. Zudem kommt es immer mal wieder vor, dass die Übertragung auf die Hololens mit einer kryptischen Fehlermeldung abbricht. Zum Teil reicht es aus, die Übertragung einfach noch einmal zu starten. Teilweise mussten wir aber auch einige Schritte zurück gehen damit es wieder funktionierte.

### Marker & Positionierung

In einem ersten Schritt wollten wir den Berg, respektive die zustäzlichen Infos via 3D-Objekterkennung anzeigen lassen. Das hätte uns einen zusätzlichen Marker erspart. Dafür haben wir auf [Vuforia](https://www.vuforia.com/) zurückgegriffen. 
Die 3D-Objekterkennung arbeitete jedoch nicht zuverlässig. Wir vermuten den Grund in den wechselnden Lichtverhältnissen. Aus diesem Grund haben wir einen 2D-Marker auf A4-Papier erstellt und ihn in einer bestimmten Position zum Berg positioniert.

Die Skalierung und Positionierung des 3D-Objekts auf den physische Modell war die nächste Herausforderung. Da die beiden Grössenmasse in keinem Verhältnis zueinander stehen, mussten wir schlussendlich solange an den Grössen drehen, bis wir ein zufriedenstellendes Ergebnis erhielten.

### Zu viele Polygone

Ein weiteres Problem waren die vielen Polygone. Am Anfang standen wir bei gesamthaft 142'000 Polygonen in der Applikation. Dies machte sich in der Performance bemerkbar. Die Applikation war entsprechend schwerfällig und der Cursor hinkte hinterher. Das lag vor allem an unserem Bergmodell, das wir dieses mit der App in ein 3D-Model umgewandelt hatten. Dank Instant Meshes und durch Entfernen des Lichts in der Szene konnten wir diese Zahl erheblich verringern.

## Code 

Im Code haben wir bestehenden Szene um Interaktionsmöglichkeiten erweitert. Wir haben den Code so modular wie möglich geschrieben, sodass er auf neu importierte Elemente einfach angewendet werden kann. In einem zentralen Skript haben wir Kollisionen abgefangen und entsprechende Events an die restliche Game Objects gesendet. Diese wurden wiederum von den betroffenen abgefangen und je nach Typ des Objekts (Weg, Icon, Panel) entsprechend behandelt.

## Learnings

Für weitere Projekte müssten wir sicher nach einer effizienteren Entwicklungsumgebung suchen. Die langen Wartezeiten haben uns ziemlich ausgebremst. Ebenfalls war das eingeschränkte Sichtfeld/Projektionsfeld der Hololens enttäuschend klein. Wie im Video oben ersichtlich, muss man sich teilweise sehr weit weg vom Modell positionieren, um die gesamte Szene im Blickfeld zu haben. Wir haben auch erkannt, dass feine Farbunterschiede, wie wir sie im Web bespielsweise für verschiedene Stati verwenden (hover/clicked/etc.), auf der Hololens nicht oder nur schlecht funktionieren. Es sind grosse Kontraste nötig um Unterschiede zu erkennen. 

## Potentielle Weiterentwicklung
Einige Punkte, mit denen diese Applikation weiterentwickelt werden könnte.

- Das Panel mit Funktonen und Hintergrundinfos ausstatten
- Einbinden von Wetterdaten mit der entsprechenden Visualisierung
- Serialisierung des Objektimports, mit dem Ziel, beliebige Berge in die Applikation integrieren zu können. Das erfordert unter anderem eine Umrechnung von GPS-Daten in Unity-Koordinaten
- Portierung auf andere Geräte

[logo]: Holographic-Grisons/docs/mmp_ma_hg_trigger.jpg "Holographic Grisons"
