\ include timer.fs

hex
nvm
: emits 0 do emit loop ;  

: sync c0 
	01 00  00 00  89 02  00 00 
	0a e0 
	c0 0c emits 
	;

: mqtt-setup  c0 
	0a 00  04 00  00 00  00 00 
	04 00  6b 02  00 00  \ length, bytes
	04 00  71 02  00 00  
	04 00  77 02  00 00  
	04 00  7d 02  00 00 
	dc 43 
	c0 24 emits 
	;

: message0 c0 
	0b 00  05 00  00 00  00 00 
	0b 00  2f 65 73 70 
           2d 6c 69 6e 6b 2f 31 00  
	01 00  30 00  00 00  \ data
	02 00  01 00  00 00  \ len of data  
	01 00  00 00  00 00  \ qos
	01 00  00 00  00 00  \ retain
	e5 ae 
	c0 32 emits
	;

: get-time c0 
	07 00  00 00  00 00  00 00  
	0e 9c  
	c0 0c emits
;
ram

dec
