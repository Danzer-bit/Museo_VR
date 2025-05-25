# 🏛️ Museo VR

![Museo VR Banner](https://images.unsplash.com/photo-1621791060028-5ba5b74aa80a?ixlib=rb-4.0.3&auto=format&fit=crop&w=1950&q=80)

Il progetto Museo VR è un'esperienza immersiva in realtà virtuale creata con Unity 6 (URP), che ti permette di esplorare un museo virtuale diviso in tre esposizioni.

## 🎮 Descrizione del progetto

Museo VR è un progetto interattivo che combina arte, scienza e storia all'interno di un ambiente tridimensionale progettato per la realtà virtuale. Il progetto è stato sviluppato utilizzando Unity 6 con URP (Universal Render Pipeline), in combinazione con il toolkit MRTK (Mixed Reality Toolkit), per supportare un'esperienza VR avanzata e compatibile con diversi dispositivi.

🎥 Anteprima:

![Preview GIF](https://media.giphy.com/media/3o7TKP2vIT7mpbZzUQ/giphy.gif)

Il museo è composto da tre sale principali:

### 🌀 1. Esposizione di Illusioni Ottiche
Un viaggio nel mondo della percezione visiva. Questa sezione include installazioni interattive, pattern geometrici e ambientazioni che mettono alla prova la mente e l'occhio umano.

![Illusione ottica](https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/Cafe_wall_illusion.svg/800px-Cafe_wall_illusion.svg.png)

### 🗿 2. Esposizione di Sculture
Una galleria che ospita opere scolpite in 3D, dalle forme classiche a quelle contemporanee. Le sculture possono essere osservate da ogni angolazione e in scala reale.

![Scultura 3D](https://upload.wikimedia.org/wikipedia/commons/thumb/7/7e/3D-printed_statue_of_David.jpg/640px-3D-printed_statue_of_David.jpg)

### 🏎️ 3. Mostra sulla Storia della Formula 1
Un'esperienza che ripercorre l'evoluzione della Formula 1 attraverso modelli 3D storici, pannelli informativi, immagini d'epoca e contributi video.

![Formula 1 mostra](https://upload.wikimedia.org/wikipedia/commons/thumb/2/2d/Mercedes-Benz_W196_in_Mercedes-Benz_World%2C_Brooklands.jpg/640px-Mercedes-Benz_W196_in_Mercedes-Benz_World%2C_Brooklands.jpg)

## 🛠️ Tecnologie utilizzate

- Unity 6 con URP (Universal Render Pipeline)
- MRTK (Mixed Reality Toolkit) per interazioni e input in realtà virtuale
- Blender per la modellazione 3D
- Git e GitHub per il versionamento e la condivisione del codice

## 🚀 Obiettivi del progetto

- Offrire un'esperienza culturale e didattica immersiva
- Sperimentare con la progettazione di ambienti VR realistici e interattivi
- Condividere un progetto open-source per la comunità Unity/VR

## 📦 Installazione

1. Clona il repository:
   ```bash
   git clone https://github.com/Danzer-bit/Museo_VR.git
   ```
2. Apri il progetto in Unity 6 (assicurati di usare URP).

3. Importa eventuali pacchetti mancanti (MRTK, XR Toolkit, Input System, ecc.).

4. Configura un visore VR compatibile (Meta Quest, HTC Vive, ecc.) e avvia la scena principale.

## 🤝 Come contribuire

Se desideri collaborare al progetto, ti consiglio di lavorare su branch separati per evitare conflitti e mantenere il ramo principale (`main`) stabile.

### 📌 Flusso di lavoro consigliato (con GitHub Desktop)

1. Installa [GitHub Desktop](https://desktop.github.com/)
2. Vai alla pagina del repository su GitHub.
3. Clicca su “Code” → “Open with GitHub Desktop”.
4. Seleziona una cartella locale dove clonare il progetto.
5. In GitHub Desktop, crea un nuovo branch:
   - Vai su “Branch” → “New branch”
   - Dai un nome descrittivo, es: `feature-nuova-esposizione`
6. Apri il progetto con Unity dalla cartella locale.
7. Effettua le modifiche desiderate.
8. Torna su GitHub Desktop:
   - Inserisci un messaggio di commit descrittivo
   - Clicca su “Commit to [nome-branch]”
   - Poi clicca su “Push origin” per inviare il branch su GitHub
9. Apri una Pull Request su GitHub per proporre le modifiche.
10. Dopo la revisione, il branch può essere unito nel `main`.

ℹ️ Ricorda di aggiornare spesso il tuo branch con `main` per evitare conflitti:
```bash
git checkout main
git pull origin main
git checkout nome-del-tuo-branch
git merge main
```

## 📄 Licenza
Questo progetto è distribuito sotto licenza MIT. Consulta il file LICENSE per maggiori dettagli.
