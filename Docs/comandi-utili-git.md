#Comandi utili


##Creare repository locale**

- Creare cartella dove inizializzeremo il progetto
- Navigare al suo interno da terminale
- *git init* (inizializziamo repo)
- Iniziare a creare file


##Fare una pull request**
- Navigare nella pagina del progetto di interesse.
- Premere su fork
- Navigare nel repository del progetto ora presente nel proprio profilo
- Da terminale entrare nella cartella dove inserire il progetto
- *git clone url_del_progetto* (cloniamo in locale il progetto)
- Fare le modifiche necessarie con tutti i commit del caso
- *git push*
- Tornare nella propria pagina del github e premere su *pull request*.
- Compilare con i dati richiesti ed inviare
- Attendere conferma

## Setup
Vedere dove è locato git:
`which git`

Vedere versione di Git:
`git --version`

Creare un alias per `git status`:
`git config --global alias.st status`

Help:
`git help`

## General
Inizializzare Git:
`git init`

Aggiungere tutto all'area di Stage:
`git add .`

Aggiungere un singolo file all'area di Stage:
`git add index.html`

Creare un commit:
`git commit -m "Message"`

Creare un commit con titolo e descrizione:
`git commit -m "Title" -m "Description..."`

Aggiungere a Stage e committare in un unico comando:
`git commit -am "Message"`

Rimuovere file da git:
`git rm index.html`

Aggiornare i cambiamenti:
`git add -u`

Rimuovere file dalla Stage area:
`git rm --cached index.html`

Spostare o rinominare file:
`git mv index.html dir/index_new.html`

Tornare all'ultimo stage in un determinato file:
`git checkout -- index.html`

Fare il Restore del file da un determinato commit:
`git checkout 6eb715d -- index.html`

## Reset
Tornare indietro ad un determinato commit:
`git revert 073791e7dd71b90daa853b2c5acc2c925f02dbc6`

Soft reset:
`git reset --soft 073791e7dd71b90daa853b2c5acc2c925f02dbc6`

Cancellare l'ultimo commit: `git reset --soft HEAD~ `



## Branch
Mostra branches:
`git branch`

Crea branch:
`git branch branchname`

Cambia branch:
`git checkout branchname`

Crea e switcha ad un nuovo branch:
`git checkout -b branchname`

Rinomina branch:
`git branch -m branchname new_branchname` or:
`git branch --move branchname new_branchname`


## Merge
Eseguire un merge:
`git merge branchname`

Merge to master:
`git merge --ff-only branchname`

Merge to master (force a new commit):
`git merge --no-ff branchname`

Stop merge :
`git merge --abort`



## Log
Mostra commits:
`git log`

Mostra commit in una singola linea
`git log --oneline`

## Collaborate
Mostra remote:
`git remote`

Mostra i dettagli di remote:
`git remote -v`

Aggiungi remote upstream da GitHub project:
`git remote add upstream https://github.com/user/project.git`

Push:
`git push origin master`


Pull branch specifico:
`git pull origin branchname`

Clone su localhost:
`git clone https://github.com/user/project.git` or:
`git clone ssh://user@domain.com/~/dir/.git`

Clone su localhost folder:
`git clone https://github.com/user/project.git ~/dir/folder`

Cancella branch remoto(push nothing):
`git push origin --delete branchname`
