import win32com.client, time

def print_logo(timeout=0):
    logo = '''
                 ___  ___      _             
                / __)/ __)    (_)            
      ____ ____| |__| |__ ____ _ ____   ____ 
     / ___) _  |  __)  __) _  ) |  _ \ / _  )
    ( (__( ( | | |  | | ( (/ /| | | | ( (/ / 
     \____)_||_|_|  |_|  \____)_|_| |_|\____)
                                    - cttynul'''
    print(logo)
    if(timeout != 0): print("   Timeout set to " + str(timeout) + " seconds")


def main():
    timeout=60
    print_logo(timeout)
    while(1):
        shell = win32com.client.Dispatch("WScript.Shell")
        shell.SendKeys('{F15}')
        time.sleep(timeout)

if __name__=="__main__":
    main()