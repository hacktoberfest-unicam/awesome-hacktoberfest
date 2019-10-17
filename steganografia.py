import subprocess
def inizio():
    print("Metti l'immagine che desideri modificare nella cartella del progetto da dove parte lo script")
    testo = input('Dimmi il testo')
    immagine = input('Dimmi il nome della immagine')
    try:
        subprocess.run(['echo',testo,'>>',immagine], shell=True)
    except Exception as e:
        print(e)
inizio()