version = 1.1
import os
try:
    import sys
    sys.dont_write_bytecode = True
    from colorama import init, Fore, Style; init()
    from bs4 import BeautifulSoup
    from faker import Faker
    import webbrowser
    import subprocess
    import requests
    import string
    import random
    import time
    import json

except ModuleNotFoundError:
    print("Installing required libs... (check title for status)")
    libs = [
        "colorama",
        "bs4",
        "faker",
        "requests"
    ]
    for lib in libs:
        os.system(f"title Satuurn - installing {lib}")
        os.system(f"pip install -q {lib}")

    import sys
    sys.dont_write_bytecode = True
    from colorama import init, Fore, Style; init()
    from bs4 import BeautifulSoup
    from faker import Faker
    import webbrowser
    import subprocess
    import requests
    import string
    import random
    import time
    import json

print("Prepearing saturrn...")
stars = requests.get(f"https://api.github.com/repos/R3CI/Saturrn").json().get("stargazers_count")
red = Fore.RED
lred = Fore.LIGHTRED_EX
yellow = Fore.YELLOW
lyellow = Fore.LIGHTYELLOW_EX
green = Fore.GREEN
lgreen = Fore.LIGHTGREEN_EX
res = Fore.RESET
purple = Fore.LIGHTMAGENTA_EX
magenta = Fore.MAGENTA
orange = "\033[38;2;255;165;0m"
dorange = "\033[38;2;200;120;0m"
black = Fore.LIGHTBLACK_EX

class auto_update:
    try:
        @staticmethod
        def get_info():
            os.system("title Pluzio - Searching for updates")
            r = requests.get("https://api.github.com/repos/r3nm4rs-dev/pluzio-aio/releases/latest")
            if r.status_code == 200:
                data = r.json()
                changelog = data.get('body', '')
                version = float(data['tag_name'].lstrip('v'))
                return version, changelog
            else:
                return None, None

        @staticmethod
        def update(local, github, changelog):
            local = float(local)
            github = float(github)
            if local == github:
                pass
            else:
                if local < github:
                    os.system("title Pluzio - Update found")
                    os.system("cls")
                    banner = f"""{orange}
{"                                                               ____        "}
{"|         | |`````````, |``````.        .'.       `````|````` |            "}
{"|         | |'''''''''  |       |     .''```.          |      |______      "}
{"|         | |           |       |   .'       `.        |      |            "}
{"`._______.' |           |......'  .'           `.      |      |________    "}
"""

                    print(banner)
                    print(f"{dorange}Change log\n{changelog}")
                    input(f"\n{orange}Enter to open GitHub on the newest release")
                    webbrowser.open("https://github.com/r3nm4rs-dev/pluzio-aio/releases")
                    exit()

        gh_version, changelog = get_info()
        update(version, gh_version, changelog)
    except Exception as e:
        print(f"Error: {e}")

class Modules:
    class star:
        def __init__(self):
            pass

        def run(self):
            webbrowser.open("https://github.com/r3nm4rs-dev/pluzio-aio")
            os.system("cls")

    class temp_mail:
        def __init__(self):
            pass

        def initialize(self):
            self.fake = Faker()
            self.TMA = f"{self.gen_name()}.{self.gen_sur()}%40deecie.com"
            print(f"{orange}TMA {res}->{orange} {self.TMA}")
            self.PHPSESSID = str(self.get_cookies())
            print(f"{orange}PHPSESSID {res}->{orange} {self.PHPSESSID}")
            self.email = self.get_email(self.TMA, self.PHPSESSID)
            print(f"{orange}Email {res}->{orange} {self.email}")

        def gen_name(self):
            return self.fake.first_name()

        def gen_sur(self):
            return self.fake.last_name()

        def get_cookies(self):
            response = requests.get('https://www.disposablemail.com/')
            cookies = response.cookies
            if cookies:
                return list(cookies.values())[0]

        def get_email(self, TMA, PHPSESSID):
            headers = {
                'Host': 'www.disposablemail.com',
                'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; rv:121.0) Gecko/20100101 Firefox/121.0',
                'Accept': 'text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,*/*;q=0.8',
                'Accept-Language': 'en-US,en;q=0.5',
                'Accept-Encoding': 'gzip, deflate, br',
                'DNT': '1',
                'Sec-GPC': '1',
                'Connection': 'keep-alive',
                'Cookie': f'TMA={TMA}; PHPSESSID={PHPSESSID}',
                'Upgrade-Insecure-Requests': '1',
                'Sec-Fetch-Dest': 'document',
                'Sec-Fetch-Mode': 'navigate',
                'Sec-Fetch-Site': 'cross-site'
            }

            r = requests.get("https://www.disposablemail.com/", headers=headers)
            html = r.text
            soup = BeautifulSoup(html, 'html.parser')
            email_element = soup.find('span', {'id': 'email'})
            email_address = email_element.text.strip()
            return email_address

        def refresh(self, TMA, PHPSESSID):
            headers = {
                'Host': 'www.disposablemail.com',
                'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; rv:121.0) Gecko/20100101 Firefox/121.0',
                'Accept': 'application/json, text/javascript, */*; q=0.01',
                'Accept-Language': 'en-US,en;q=0.5',
                'Accept-Encoding': 'gzip, deflate, br',
                'X-Requested-With': 'XMLHttpRequest',
                'DNT': '1',
                'Sec-GPC': '1',
                'Connection': 'keep-alive',
                'Referer': 'https://www.disposablemail.com/',
                'Cookie': f'TMA={TMA}; PHPSESSID={PHPSESSID}',
                'Sec-Fetch-Dest': 'empty',
                'Sec-Fetch-Mode': 'cors',
                'Sec-Fetch-Site': 'same-origin'
            }

            r = requests.get("https://www.disposablemail.com/index/refresh", headers=headers)
            
            try:
                content = r.content.decode('utf-8-sig')       
                data = json.loads(content)
                return [item['predmetZkraceny'].replace('Welcome to DisposableMail...', '') for item in data]
            except json.JSONDecodeError as e:
                print(f"Error decoding JSON: {e}")
                return []
            
        def run(self):
            self.initialize()
            i = 0
            refresh_t = int(input(f"{dorange}({orange}Refresh{dorange}){orange} {res}->{orange} "))
            while True:
                i += 1
                os.system("cls")
                print(f"{dorange}({orange}Email{dorange}){orange} {res}->{orange} {self.email}")
                print(f"Refreshing... (refresh number {res}->{orange} {i}) (refresh time {res}->{orange} {refresh_t})")
                print(f"{dorange}({orange}Refresh{dorange}){orange} {res}->{orange} ", self.refresh(self.TMA, self.PHPSESSID))
                time.sleep(refresh_t)

    class cookie_fetcher:
        def __init__(self):
            pass

        def run(self):
            url = input(f"{dorange}({orange}URL{dorange}){orange} {res}->{orange} ")
            if not url.startswith(("http://", "https://")):
                url = f"https://{url}"
            try:
                r = requests.get(url, timeout=5)
                cookies = r.cookies
                succes = True
            except requests.Timeout:
                print(f"{red}Timeout")
                succes = False

            if succes:
                if cookies:
                    print(f"{dorange}Cookies returned:")
                    for cookie in cookies:
                        print(f"{orange}Name{dorange}: {dorange}{cookie.name}, {orange}Value{dorange}: {dorange}{cookie.value}")
                else:
                    print(f"{red}No cookies returned")

            input(f"{dorange}({orange}Waiting{dorange})")
            os.system("cls")
    
    class ip_generator:
        def __init__(self):
            pass
        
        def initialize(self):
            with open("ips.txt", "w") as f:
                f.write("")

        @staticmethod
        def generate_ip():
            octets = [str(random.randint(0, 255)) for _ in range(4)]
            ip_address = ".".join(octets)
            return ip_address

        @staticmethod
        def check_ping(ip):
            result = subprocess.run(['ping', '-n', '1', ip], stdout=subprocess.PIPE, text=True)
            if 'Reply' in result.stdout:
                with open("ips.txt", "a") as f:
                    f.write(ip + "\n")
                return True
            else:
                return False
            
        def run(self):
            self.initialize()
            amt = int(input(f"{dorange}({orange}Amount{dorange}){orange} {res}->{orange} "))
            i = 0
            for i in range(amt):
                i =+ 1
                ip = Modules.ip_generator.generate_ip()
                r = Modules.ip_generator.check_ping(Modules.ip_generator.generate_ip())
                if r:
                    print(f"{green}(Valid){orange} {res}  ->{orange} {ip} {dorange}({orange}{i}{dorange}){orange}")
                else:
                    print(f"{red}(Invalid){orange} {res}->{orange} {ip}")

    class leaked_ip_search:
        def __init__(self):
            pass
        
        def initialize(self):
            if os.path.exists("db.json"):
                with open("db.json", "r") as f:
                    self.data = json.load(f)
            else:
                print(f"{orange}Gathering info from database ~ 20mb")
                db = requests.get("https://raw.githubusercontent.com/R3CI/Resources/main/IPleak")

                if db.ok:
                    self.data = {}
                    for line in db.text.split('\n'):
                        parts = line.strip().split(':')
                        if len(parts) == 2:
                            username, ip_address = parts
                            self.data[username] = ip_address
                else:
                    print(f"{red}Error getting info from db {db.status_code}")
                    self.data = {}

        def find(self, username):
            username = username.strip()
            if username in self.data:
                return self.data[username]
            else:
                return None

        def run(self):
            self.initialize()
            mc_username = input(f"{dorange}({orange}Minecraft username{dorange}){orange} {res}->{orange} ")
            ip_address = self.find(mc_username)

            if ip_address:
                print(f"{green}(Found){orange} {res}->{orange} {ip_address} {dorange}")
            else:
                print(f"{red}(Not found){orange} {res} ->{orange} Nothing was found in the database {dorange}")


            if not os.path.exists("db.json"):
                if input(f"{orange}Save db for later? (y/n) {res} ->{orange} ") == "y":
                    with open("db.json", "w") as f:
                        json.dump(self.data, f)
                        print(f"{green}DB saved")

            input(f"{dorange}({orange}Waiting{dorange})")
            os.system("cls")

    class uncensored_ai:
        def __init__(self):
            pass

        def run(self):
            if input(f"{red}(WARNING) This will allow u to use an ai same level as gtp 3.5 but UNCENSORED i will be NOT reponsible on what u learn do u aggre to that? (y/n){res} ->{orange} ") == "y":
                print(f"{orange}This will take around 27 GB so be prepeared also u need to have a lot of ram 8gb will not run it 16bg maby? 32gb whould with some lag 64gb ur chilling")
                if input(f"{orange}Are u on windows? (easier if ur on linux) (y/n){res} ->{orange} ") == "y":
                    print(f"""
{dorange}STEP 1:{orange} Download WSL after that restart ur pc and finish install of WSL
{dorange}STEP 2:{orange} Open visual studio code and click on the blue box and the bottom left click on it and chose connect to WSL
{dorange}STEP 3:{orange} Hold controll + shift and click ` (button next to 1)
{dorange}STEP 4:{orange} Paste this into the cmd "curl https://ollama.ai/install.sh | sh"
{dorange}STEP 5:{orange} Run "ollama serve"
{dorange}STEP 6:{orange} Make a new cmd window (DO NOT CLOSE THE PREVIOUS ONE) (to get a seperate terminal just click the plus on the alerdy exisiting one)
{dorange}STEP 7:{orange} Run "ollama run " and the model of ai u want dolphin is prob the best one so just run "Run ollama doplhin-mixtral:latest" 
{dorange}STEP 8:{orange} And now u just have to wait until the model downloads (around 26gb) its a onetime download ofcoruse
{dorange}STEP 9:{orange} Now all u need to do is just run the promt u want can be literary anything soo yk remember what u agreed on tho

{dorange}To rerun after downloading and setting up
{dorange}STEP 1:{orange} Open visual studio code again click on the blue box on the bottom left and chose connect to wsl 
{dorange}STEP 2:{orange} Open cmd by holding controll + shift and click ` (button next to 1)
{dorange}STEP 3:{orange} Run "ollama serve"
{dorange}STEP 4:{orange} Make a new cmd window (DO NOT CLOSE THE PREVIOUS ONE) (to get a seperate terminal just click the plus on the alerdy exisiting one) 
{dorange}STEP 5:{orange} Run "ollama run " and the model of ai u want dolphin is prob the best one so just run "Run ollama doplhin-mixtral:latest"
{dorange}STEP 6:{orange} Write anything u want and now it will answer your question but dont go too crazy
""")
                else:
                    print(f"""
{dorange}STEP 1:{orange} Open cmd and paste "curl https://ollama.ai/install.sh | sh"
{dorange}STEP 2:{orange} Run "ollama serve"
{dorange}STEP 3:{orange} Open another cmd window wighout closing the other one
{dorange}STEP 4:{orange} Run "ollama run " and the model of ai u want dolphin is prob the best one so just run "Run ollama doplhin-mixtral:latest" 
{dorange}STEP 5:{orange} And now u just have to wait until the model downloads (around 26gb) its a onetime download ofcoruse
{dorange}STEP 6:{orange} Now all u need to do is just run the promt u want can be literary anything soo yk remember what u agreed on tho

{dorange}To rerun after downloading and setting up
{dorange}STEP 1:{orange} Open cmd
{dorange}STEP 2:{orange} Run "ollama serve"
{dorange}STEP 3:{orange} Open another cmd window wighout closing the other one
{dorange}STEP 4:{orange} Run "ollama run " and the model of ai u want dolphin is prob the best one so just run "Run ollama doplhin-mixtral:latest"
{dorange}STEP 5:{orange} Write anything u want and now it will answer your question but dont go too crazy
""")
            input(f"{dorange}({orange}Waiting{dorange})")
            os.system("cls")
    
    class webcam_spy:
        def __init__(self):
            pass
        def run(self):
            if input(f"{red}Ise a good webbrowser like librewolf to make sure u dont fall to a trap and DO NOT CLICK ON ANY WEBCAM WITH A HONEYPOT TAG understood? (y/n){res} ->{orange} ") == "y":
                webbrowser.open("https://www.shodan.io/search?query=Webcam")
            input(f"{dorange}({orange}Waiting{dorange})")
            os.system("cls")

    class random_ss:
        def __init__(self):
            pass

        def run(self):
            def open():
                url = f"https://prnt.sc/{''.join(random.choices(string.ascii_lowercase, k=2)) + ''.join(random.choices(string.digits, k=4))}"
                webbrowser.open(url)
            open()
            def ask():
                if input(f"{orange}Open again? (blank for yes/ n for no){res} ->{orange} ") == "":
                    open()
                    ask()
            ask()
            input(f"{dorange}({orange}Waiting{dorange})")
            os.system("cls")


version_info = sys.version_info
os.system(f"mode con: cols=170 lines=35")
while __name__ == "__main__":
    os.system(f"title Saturrn - python {version_info.major}.{version_info.minor}.{version_info.micro}")
    size = os.get_terminal_size().columns

    banner = f"""{orange}
{"            ..''''       .'.       `````|````` |         | |`````````, |`````````, |..          | ".center(size)}
{"         .''           .''```.          |      |         | |'''|'''''  |'''|'''''  |  ``..      | ".center(size)}
{"      ..'            .'       `.        |      |         | |    `.     |    `.     |      ``..  | ".center(size)}
{"....''             .'           `.      |      `._______.' |      `.   |      `.   |          ``| ".center(size)}
"""

    print(banner)
    opts = f"""
stars -> {stars} [star]
dsc.gg/saturrn      
                                               
{"[01] -> Temp mail        [07] -> Random ss        [13] -> ???              [19] -> ???              [25] -> ???              [31] -> ???".center(size)}
{"[02] -> Cookie fetcher   [08] -> ???              [14] -> ???              [20] -> ???              [26] -> ???              [32] -> ???".center(size)}
{"[03] -> IP generator     [09] -> ???              [15] -> ???              [21] -> ???              [27] -> ???              [33] -> ???".center(size)}
{"[04] -> Leaked IP search [10] -> ???              [16] -> ???              [22] -> ???              [28] -> ???              [34] -> ???".center(size)}
{"[05] -> Uncensored ai    [11] -> ???              [17] -> ???              [23] -> ???              [29] -> ???              [35] -> ???".center(size)}
{"[06] -> Webcam spy       [12] -> ???              [18] -> ???              [24] -> ???              [30] -> ???              [36] -> >>>".center(size)}
"""
    for x in ["[","]","->"]:
        opts = opts.replace(x, f"{dorange}{x}{orange}")
    print(opts)

    c = input(f"{dorange}({orange}Option{dorange}){orange} {res}->{orange} ")
    print(f"{orange}Prepearing...")
    options = {
        "star": Modules.star().run,
        "STAR": Modules.star().run,
        "1": Modules.temp_mail().run,
        "2": Modules.cookie_fetcher().run,
        "3": Modules.ip_generator().run,
        "4": Modules.leaked_ip_search().run,
        "5": Modules.uncensored_ai().run,
        "6": Modules.webcam_spy().run,
        "7": Modules.random_ss().run,
    }

    if c in options:
        os.system("cls")
        banner = f"""{orange}
{"            ..''''       .'.       `````|````` |         | |`````````, |`````````, |..          | ".center(size)}
{"         .''           .''```.          |      |         | |'''|'''''  |'''|'''''  |  ``..      | ".center(size)}
{"      ..'            .'       `.        |      |         | |    `.     |    `.     |      ``..  | ".center(size)}
{"....''             .'           `.      |      `._______.' |      `.   |      `.   |          ``| ".center(size)}
"""
        print(banner)
        options[c]()
    else:
        print(f"{red}(Invalid option)")
        time.sleep(3)
        os.system("cls")