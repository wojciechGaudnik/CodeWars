# Project Title

![CodeWars](https://www.codewars.com/users/bq666/badges/micro)
![TryHackMe](https://tryhackme-badges.s3.amazonaws.com/bq666.png)


  
This is a part of solved and in progress Katas from Code Wars


## Getting Started
My first learning project whose purpose was to implement Enigma cipher with many more combinations. Simple setup with 2048 key bit and with 100 rotors gives 2.96E+722 combinations. With -f switch we can much more cross this limit. Standard Enigma can give us 150 million combinations. 
Short pieces of information on how to use this script. 


```
Simple programme for encrypts and decrypts files.
Usage:      simnigma -c [file of files, you can use reg.]  
                Encryption the file (default key will be used the last created in the keys directory,
                the drums will be loaded with all the last ones created in the rotors directory)  
            simnigma -d [file of files, you can use reg.]
                Decryption the file (default are the same as with encryption)
            simnigma -c [file] -k [file or key name in dictionary keys]  
                Encryption with the indicated key
            simnigma -d [file] -k [file or key name in dictionary keys]  
                Decryption with the indicated key
            simnigma -c [file] -k [file] -r [first rotor file, or name in dictionary rotors]
                Encryption with the indicated key and indicated rotors and their number
            simnigma -d [file] -k [file] -r [first rotor file, or name in dictionary rotors]
                Decryption with the indicated key and indicated rotors and their number
            
            simnigma -K [name], [size]      Create key, size in bits. 
            simnigma -R [name], [number]    Create rotors, name only common part, number of created rotors
            
            simnigma -v --verbose           Show all progress
            simnigma -s --silent            If you wont to encrypt text directly from keybord or if you decript txt file, 
                                            use this option if you wont only read mesages without save files
            
            simnigma -h --help              Display this help and exit
            simnigma -V --version           Output version information and exit
            simnigma -s --silent            Encrypt only from screen and Decrypt only on screen
            # todo simnigma -t --tests      Run tests encrypt and decrypt
            # todo simnigma -rsa            Lock and anlock with rsa keys
            
Examples:   
			
More examples:
            simnigma.py -K your_key_name 2048 
                First you need to create a random key, 2048 it is size in bit. The Key will be saved in /keys diroctory of simnigma 
            simnigma.py -R your_rotors_name 20 
                Then you have to create a random 8-bit rotors, 8bit is the default setting for files, 
                20 is the number of rotors 
            simnigma.py -c some_file.txt [-k your_key_name] [-r your_rotors_name] 
                Now you can encrypt any file or files if you use reg. [for example *], encrypted files
                will be updated .enc. You can also use a different key or rotors if you insert the -k or -r option.
                By default, the most recently created keys and rotors are loaded from the keys and rotors 
                catalogs from the simnigma.py directory or if you are working on linux and connect USB than key and rotors
                will be loaded from pendrive.
            simnigma.py -d some_file.txt.enc [-k your_key_name] [-r your_rotors_name] 
                And last you can decrypt file or files, remember that you must use the same rotors and keys as
                 you use to encrypt, what is logically

            simnigma.py -K your_key_name.key key will be saved in current directory 


```

## Screenshots
![Example screenshot](./screenshots/key.png)
![Example screenshot](./screenshots/rotors.png)
![Example screenshot](./screenshots/eprogress.png)
![Example screenshot](./screenshots/encrypted.png)
![Example screenshot](./screenshots/decrypted.png)
![Example screenshot](./screenshots/all.png)

## Tech_Stack 
* Python 

## Installing

A step by step series of examples that tell you have to get a development env running

Say what the step will be

```
chmode + x simnigma

```

## Contact
Created by:
* [Gaudnik Wojciech](mailto:gaudnik.wojciech@gmail.com) - feel free to contact me! 
