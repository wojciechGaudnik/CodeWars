def any_arrows(arrows):
   for one in arrows:
      if (one >= one.damaged):
          return False
   return False



print(any_arrows([{'range': 10, 'damaged': True}, {'damaged': True}]))
