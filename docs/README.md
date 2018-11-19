Holographic Grisons

Die Holographic Grisons App projiziert virtuelle Informationen auf ein physisch vorhandenes Bergmodell. Die Applikation läuft auf der Microsoft Hololens. Diese Projekt wurde im Rahmen des Major Media Applications an der HTW Chur und der BFH erstellt.

(Bild/Screenshot)

So bekommt der interessierte Benutzer beispielsweise ein Gefühl für die Beschaffenheit der Wanderwege und die Möglichkeiten vor Ort. Diese Informationen können an die eigene E-Mail Adresse versendet werden. 

## Zugangsdaten

Sämtlicher Code für dieses Projekt ist auf Github gehostet.

[https://github.com/pscllbssr/Holographic-Grisons](https://github.com/pscllbssr/Holographic-Grisons)

## Konzeption & Testing

<table>
  <tr>
    <td></td>
    <td></td>
  </tr>
  <tr>
    <td></td>
    <td></td>
  </tr>
  <tr>
    <td></td>
    <td></td>
  </tr>
</table>


## verwendete Technologien

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

Das in Unity erstellte Projekt lässt sich in Microsoft Visual Studio importieren, um es anschliessend auf die Hololens zu übertragen. Dazu muss die Hololens einmalig konfiguriert werden, danach wird eine bestehende WLAN-Verbindung benötigt. In Visual Studio lässt sich die Applikation zudem debuggen.

## Technische Herausforderungen

### Entwicklungsumgebung für Hololens

Erfordert eine Hololens, Anforderungen an Entwicklungs-Maschine

### Umgang mit Hololens (Eigenschaften)/Debugging

### richtige/statische Positionierung

### Zu viele Polygone

## Learnings

## Potentielle Weiterentwicklung

