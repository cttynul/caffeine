import win32com.client
import time
import argparse

def print_logo(timeout=0):
    logo = '''
                    ___  ___       _
                   / __)/ __)
     ____ ____| |__| |__ ____ _ ____    ____
    / ___) _  |  __)  __) _  ) |  _ \ / _  )
   ( (__( ( | | |  | | ( (/ /| | | | ( (/ /
    \____)_||_|_|  |_|  \____)_|_| |_|\____)
                                        - cttynul'''
    print(logo)
    if timeout != 0:
        print("    Timeout set to " + str(timeout) + " seconds")


def main():
    parser = argparse.ArgumentParser(description="Caffeine for Windows in a pythonic way")
    
    parser.add_argument(
        '-t', '--time',
        type=int,
        default=60,
        help='Timeout in seconds (default: 60)'
    )
    
    args = parser.parse_args()
    timeout = args.time
    
    if timeout <= 0:
        timeout = 60

    print_logo(timeout)
    while True:
        shell = win32com.client.Dispatch("WScript.Shell")
        shell.SendKeys('{F15}')
        time.sleep(timeout)

if __name__ == "__main__":
    main()
