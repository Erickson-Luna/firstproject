import sys
from time import sleep
import time 

def print_lyrics():
    lines = [
       
        
        ("Pero ngayon ay parang kakaiba", 0.08), #1
        ("Pag nakatingin sa`yong mata", 0.08), #2
        ("Ang mundo ay kalma", 0.07), #3
        ("Ngayong nandiyan kana di magmamadali", 0.07), #4
        ("Ikaw lang ang katabi", 0.07), #5
        ("hanggang sa ang buhok ay pumuti", 0.07), #6
        ("Di na maghahanap ng kung anong ", 0.07), #7
        ("Sagot sa mga tanong", 0.09),#8
        ("Dahil ikaw ang katiyakan ko", 0.08),#9
        ("Hinding hindi na ako bibitaw", 0.10),#10
        ("Ngayong ikaw na ang ka sayaw", 0.11),#11
        ("Kung meron mang kulay", 0.07),#12
        ("Ang aking nagsisilbing tanglaw", 0.11),#13
        ("Ikaw, ikaw ay Dilaw", 0.12)#14
        
    ]

    delays = [ 0.8, 0.1, 0.8, 0.4, 0.3,
                 1, 0.2, 0.2, 0.7,   1.2,
               0.9, 0.2, 0.9, 0.3 ]

    for i, (line, char_delay) in enumerate(lines):
        for char in line:
            print(char, end='')
            sys.stdout.flush()
            sleep(char_delay)
        time.sleep(delays[i])         
        print('')

print_lyrics()
