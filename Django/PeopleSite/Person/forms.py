<<<<<<< HEAD
from django import forms

from .models import Person

class PersonForm(forms.Form):

    your_name = forms.CharField(label='Your name', max_length=250)
    your_email = forms.CharField(label='Your email', max_length=250)
=======
from django import forms

from .models import Person

class PersonForm(forms.Form):

    your_name = forms.CharField(label='Your name', max_length=250)
    your_email = forms.CharField(label='Your email', max_length=250)
>>>>>>> 876b41aeb823c6e366286fa3d8fee5e3c2b1eb21
