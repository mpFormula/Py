import System.Drawing
import System.Windows.Forms

from System.Drawing import *
from System.Windows.Forms import *

class MainForm(Form):
	def __init__(self):
		self.InitializeComponent()
	
	def InitializeComponent(self):
		# 
		# MainForm
		# 
		self.Name = "MainForm"
		self.Text = "TestPythonWin"

