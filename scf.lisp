;;;; Il gioco Sasso, Carta e Forbici in LISP
;;;; Per poter giocare:
;;;;    Installare SBCL
;;;;    Eseguire: sbcl --load scf.lisp
;;;; In altrenativa usa un interprete online come:
;;;;   Funziona solo con il compilatore SBCL


; Dichiarazione variabili
(defvar UNI) ; Giacatore 1
(defvar CAM) ; Giocatore 2
(defvar PUNTI) ; Punteggio

(write-line "Iniziare una partita? [Y/N]")
(unless (equal (read) 'Y) ; Se l'input e' diverso da Y allora esci
  (exit))

(setf PUNTI 0) ; Imposto punti a 0

(loop ; Loop infinito finche non trova un return
 (write-line "UNI scegli: Sasso(S), Carta(C), Forbice(F)")
 (setq UNI (read)) ; Leggi input UNI
 (write-line "CAM scegli: Sasso(S), Carta(C), Forbice(F)")
 (setf CAM (read)); Leggi input CAM

 ;; Blocco logico
 ; Se UNI e CAM sono uguali esci, per non far aggiunger punti se i giocatori hanno giocato la stessa mano
 (unless (equal UNI CAM)
	 (if (or
		(and (equal UNI 'S) (equal CAM 'F))
		(and (equal UNI 'C) (equal CAM 'S))
		(and (equal UNI 'F) (equal CAM 'C)))
	   (setf PUNTI (+ PUNTI 1)) ; Incremento PUNTI di 1
	 (setf PUNTI (- PUNTI 1)))) ; Decremento PUNTI di 1
 
 (when (equal PUNTI 3)
   (write-line "UNI ha vinto!")
   (return))
 (when (equal PUNTI -3)
   (write-line "CAM ha vinto")
   (return))); Fine loop

(terpri)
(sb-ext:quit)
