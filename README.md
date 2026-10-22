# GD3_BoardGameUnity_ManceauJulie
## 1. Présentation du projet

Le but de ce projet est de produire un jeu de type « jeu de l’oie », jouable à plusieurs joueurs sur un même écran (minimum 2 joueurs).

---

## 2. Concept et contexte

Le contexte de la situation : deux prisonniers tentent de s’échapper de prison, le but est de s’échapper le premier, sans se faire attraper définitivement par le gardien de prison tout en résistant aux épreuves et aléas de la course poursuite.

### Intention de jeu
Apporter du fun et de la tension à l'expérience à travers les évènements, le son et les animations

### Ambiance et direction artistique
DA cartoonesque, couleurs et décor en accord avec le thème de la prison (exemple: gris, orange...)

---

## 3. But et règles de déplacement

Le but de ce jeu est d’atteindre la case finale du plateau, tout en respectant la règle de déplacement du jeu de l’oie : si le résultat du lancer de dé est supérieur au nombre de cases manquantes, le joueur part en arrière du nombre de cases qui lui reste à parcourir.

Les joueurs peuvent se retrouver sur la même case ou se dépasser.

Au départ, les joueurs utilise un dé "classique" à 6 faces.

Nombre de cases totale du jeu: environ 60 
Chaque joueur possède 10 pépites (pièces) au début de la partie

### Condition de victoire
Le gagnant est le premier joueur ayant atteint la sortie de la prison (dernière case) ou le dernier "survivant" du plateau.

---

## 4. Le gardien de prison

Le gardien est un pion qui avance de 1 à 2 cases (aléatoire) tous les 3 tours.

### Règles du gardien
Le gardien poursuit les prisonniers pour les attraper. Si il dépasse un des prisonniers, celui-ci est officiellement éliminé.

---

## 5. Les cases spéciales

Certaines cases du jeu proposent des effets particuliers.

### Cases positives

- **+2 :** le joueur avance de deux cases supplémentaires.
- **Rejouer :** le joueur relance son dé.
- **Le raccourci (pont du jeu de l’oie) :** reprise d’une case du jeu de l’oie, si le joueur tombe précisément sur cette case, il se dirige directement sur une autre case plus loin prédéfinie. -> valable dans les deux sens

### Cases négatives

- **Blocage :** le joueur doit passer son tour.
- **Croche-patte :** le joueur recule de 2 cases.

---

## 6. Case boutique clandestine

Le joueur va pouvoir acheter des objets divers pour avancer plus vite ou embêter le ou les joueurs adverses.
(prix des objets à définir)

### Objets envisagés

- **Dé nombre pair**
- **Dé de la fatigue** a donner à l’adversaire se son choix qui le force a tirer un dé qui propose seulement des 0,1ou2.
- **Leurre** fait ralentir le gardien pour ses prochain déplacements (il saute son tour)
- **haut parleur** attire le gardien et le fait avancer de 1 à 2 cases directement après utilisation de l'objet

### Fonctionnement de la boutique
Le joueur peut acheter ces objets seulement lorsqu'il est sur une case boutique clandestine. Le joueur n'est pas obligé d'acheter un objet

### Monnaie du jeu
des pépites

---

## 7. Mini-jeux

Des cases mini-jeux permettent de déclancher de gagner des pièces pour acheter des éléments dans la boutique (ou autre).
Une autre condition peut déclancher un mini-jeu: lorsque deux joueurs se retrouvent sur la même case

### Mini-jeu : Cache-cache

- Les deux joueurs se cachent dans un lieu restraint et un robot de patrouille (IA) tente de les trouver dans le temps imparti. les joueurs ont moins de possibilité de déplacement une fois le robot en patrouille (comme de l'énergie qui ne se regagne pas)

### récompenses du mini-jeu

Le gagnant gagne 8 pièces et le perdant 3
Si les deux joueurs sont perdants, ils gagnent tout deux 1 pièce et si les deux sont gagnants ils gagnent 5 pièces chacun
D'autres possibilités de récompenses sont libre

---

## 8. Quêtes

Des cases demanderont au joueur des quêtes particulières afin de gagner de l’argent ou un bonus pour le joueur (objet, avancer d'un certain nombre de cases -> choix libre). Elles sont lancées par un dialogue avec un autre prisonnier présent sur une case (ou plusieurs) cases allouées. La personne ayant échoué/raté la quête recule de 2 cases

### Idées de quêtes

- Le joueur doit obtenir une valeur précise au dé (en 3 chances)
- Défier un autre joueur : chacun lance le dé et le meilleur résultat remporte la récompense.
- Bonus : ramasser un certain nombre d'objets disposé sur le plateau en un nombre de tour donné
- Modification de quête/ ajout de quête libre
