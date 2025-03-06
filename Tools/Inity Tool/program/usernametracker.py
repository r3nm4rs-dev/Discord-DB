import requests
import os

sites = {
    "Twitter": "https://twitter.com/{}",
    "Instagram": "https://www.instagram.com/{}",
    "GitHub": "https://github.com/{}",
    "Reddit": "https://www.reddit.com/user/{}",
    "Pinterest": "https://www.pinterest.com/{}",
    "SoundCloud": "https://soundcloud.com/{}",
    "Tiktok": "https://www.tiktok.com/search/user?q={}"
}

def check_username(username):
    available_sites = []
    for site, url in sites.items():
        check_url = url.format(username)
        response = requests.get(check_url)
        if response.status_code == 200:
            available_sites.append(site)
            print(f"[+] {username} found in {site} : {check_url}")
        else:
            print(f"[-] {username} not found in {site}")

    if not available_sites:
        print(f"\nUsername '{username}' have zero results")
    else:
        print(f"\nUsername '{username}' was found in : {', '.join(available_sites)}")


if __name__ == "__main__":
    username_to_check = input("Type the username to check : ")
    check_username(username_to_check)

finish = "[ + ] Done Checking | Type 0 To Go Back"


reponse=input(finish)
if "0" in reponse.lower():
        os.system('cls')
        os.system('python Main.py')