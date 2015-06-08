
import os
import sys
LOPath = 'I:\\Extra\\PortableApps\\LibreOfficePortable\\App\\libreoffice\\'
os.environ['PATH']  += os.pathsep + LOPath + 'URE\\bin'
os.environ['PATH']  += os.pathsep + LOPath + 'program'
os.environ['URE_BOOTSTRAP'] = 'vnd.sun.star.pathname:' + LOPath + 'program\\fundamental.ini'
os.environ['UNO_PATH'] = LOPath + 'program\\'
sys.path.append(LOPath + 'program')

import pyoo
desktop = pyoo.Desktop('localhost', 2002)
doc = desktop.create_spreadsheet()
doc.sheets[0]
sheet = doc.sheets[0]
str(sheet[0,0].address)
sheet[0,0].value = 1
sheet[0,1].value = 2
sheet[0,2].formula = '$A$1+$B$1'
sheet[0,2].formula = '=$A$1+$B$1'
sheet[0,2].value
sheet[1:3,0:2].values = [[3,4],[5,6]]
sheet[3,0:2].formulas = ['=$A$1+$A$2+$A$3', '=$B$1+$B$2+$B$3']
sheet[3,0:2].values
##doc.close()

