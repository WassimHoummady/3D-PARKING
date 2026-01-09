Ce projet est une application XR data-driven développée avec Unity 2022.3 LTS, simulant un parking intelligent dans un environnement 3D immersif, sans utilisation de casque VR.

Chaque place de parking représente une donnée avec un état dynamique (Libre, Réservée, Occupée), visualisé en temps réel par un feedback visuel clair.
L’objectif est de permettre à l’utilisateur de visualiser l’état du système, interagir avec les données et observer les conséquences de ses décisions, comme dans un système réel de supervision (Smart City, IoT, Digital Twin).

Mode XR: VR simulée -Interaction via souris-Aucun matériel XR requis


Fonctionnalités principales:

Visualisation data-driven des places de parking

États dynamiques avec code couleur (vert / orange / rouge)

Interaction utilisateur par sélection de véhicules

Interface utilisateur avec boutons et messages de feedback

Application de règles métier simples (validation, refus, conséquence)

Effets visuels lors des événements critiques


Architecture logicielle:

Le projet suit une architecture modulaire de type Manager :

ParkingManager : gestion centrale des données du système

ParkingSpot : représentation des données et des états

CarController : logique de déplacement et d’actions

UIManager : gestion de l’interface utilisateur et du feedback
