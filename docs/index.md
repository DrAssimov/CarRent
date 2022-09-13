# CarRent
CarRent ist die Pflichtaufgabe aus dem Modul Softwarearchitektur und -design, umgesetzt von Gabriel Imhof und am 13.09.2022 über die Lernplattform abgegeben.

##Einführung
Es soll ein neues Autovermietungssystem „CarRent“ erstellt werden. Das System soll aus einem Server-Teil und optional einen Web-Client bestehen.

  a) Die Daten sollen mittels Repository Pattern in eine Datenbank gespeichert werden können.
  b) Die Business Logik soll auf dem Backend laufen und eine REST APIs anbieten.
  c) Es soll zuerst ein Monolith erstellt werden und später auf eine Micro Service Architektur überführt werden.

##Anforderungen an das zu entwickelnde System
  • Der Sachbearbeiter kann Kunden mit Namen und Adresse und Kundennummer im System verwalten, d.h. erfassen, bearbeiten, löschen und den Kunden mit dessen Namen oder Kundennummer suchen.
  • Der Sachbearbeiter kann zudem die Autos von CarRent verwalten und nach denen suchen.
  • Jedes Auto kann einer bestimmten Klasse zwischen Luxusklasse, Mittelklasse oder Einfachklasse zugeordnet werden und besitzt zudem eine Marke, einen Typ und eine eindeutige Identifikation.
  • Jede Klasse besitzt eine Tagesgebühr.
  • Bei einer neuen Reservation kann der Kunde ein Auto aus einer bestimmten Klasse wählen. Er muss zudem die Anzahl der Tage angeben, die er das Auto gerne mieten möchte. Dabei werden die Gesamtkosten berechnet. Wird die Reservation gespeichert, so wird sie mit einer Reservationsnummer ablegt.
  • Bei Abholung des Autos wird die Reservation in einen Mietvertrag umgewandelt.

##C4 Model
###System context

###Container

###Components

###Class
