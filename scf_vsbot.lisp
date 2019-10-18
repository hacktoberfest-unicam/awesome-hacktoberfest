(defvar UNI) ; Giocatore 1
(defvar CAMBOT) ; Giocatore 2 
(defvar PUNTI 0)
(setq *random-state* (make-random-state t)) ; Cambio lo stato di RANDOM ad ogni esecuzione

(loop
 (setq CAMBOT (nth (random (length '(S C F))) '(S C F))) ; Scegli una mano random
 (format t  "~%~%PUNTI: ~D~%Scegli (S)asso (C)arta (F)orbice" PUNTI) ; Intestazione: Come giocare
 (format t "~%Turno di UNI: ") (finish-output nil) (setq UNI (read)) ; Prendi in input la mano del Giocatore 1
 (format t "Turno di CAMBOT: ~A " CAMBOT) ; Visualizza la giocata del Giocatore 2

 (unless (equal UNI CAMBOT) ; Se i giocatori hanno avuto la stessa mano, non fare nulla
   (if (or ; Logica del gioco
	(and (equal UNI 'S) (equal CAMBOT 'F))
	(and (equal UNI 'C) (equal CAMBOT 'S))
	(and (equal UNI 'F) (equal CAMBOT 'C)))
       (setq PUNTI (+ PUNTI 1)) ; Incremento Punti
     (setq PUNTI (- PUNTI 1)))) ; Decremento Punti
 
 (when (equal PUNTI 3) (format t "~%UNI ha vinto!") (return)) ; Vince Giocatore 1
 (when (equal PUNTI -3) (format t "~%CAMBOT ha vinto!") (return))) ; Vince Giocatore 2
