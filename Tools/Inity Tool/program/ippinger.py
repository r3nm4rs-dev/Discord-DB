import os
import colorama
import threading
import requests
import sys,os
from colorama import Fore
colorama.init()


os.system('cls')

print("\033[1;32m")


def dos(target):
    while True:
        try:
            res = requests.get(target)
            print("Request sent!")
        except requests.exceptions.ConnectionError:
            print("[!!!] " + "Connection Failed!")
 
threads = 20

print(Fore.BLUE+"""
██╗██████╗     ██████╗ ██╗███╗   ██╗ ██████╗ ███████╗██████╗ 
██║██╔══██╗    ██╔══██╗██║████╗  ██║██╔════╝ ██╔════╝██╔══██╗
██║██████╔╝    ██████╔╝██║██╔██╗ ██║██║  ███╗█████╗  ██████╔╝
██║██╔═══╝     ██╔═══╝ ██║██║╚██╗██║██║   ██║██╔══╝  ██╔══██╗
██║██║         ██║     ██║██║ ╚████║╚██████╔╝███████╗██║  ██║
╚═╝╚═╝         ╚═╝     ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝
                                                                                             
           """)

print('-' * 60)

print('ip pinger')
print('-' * 60)


ip_to_check = input('Give me an IP to ping : ')

print('-' * 60)
os.system('ping -n 5 {}'.format(ip_to_check))
print('-' * 60)

import time
time.sleep(4)
os.system('cls')
os.system("python Main.py")
print("You will be redirected in 3 seconds")