<<<<<<< HEAD
from django.db import models

class Person(models.Model):
    name = models.CharField(max_length=250)
    email = models.CharField(max_length=250)
    profile_picture = models.CharField(max_length=250, default='')

    def __str__(self):
        return self.name + ' - ' + self.email

class Item(models.Model):
    owner = models.ForeignKey(Person, on_delete=models.CASCADE)
    name = models.CharField(max_length=250)
    weight = models.CharField(max_length=250)
    picture = models.CharField(max_length=250, default='')
    is_favourite = models.BooleanField(default=False)
    def __str__(self):
        return self.name
=======
from django.db import models

class Person(models.Model):
    name = models.CharField(max_length=250)
    email = models.CharField(max_length=250)
    profile_picture = models.CharField(max_length=250, default='')

    def __str__(self):
        return self.name + ' - ' + self.email

class Item(models.Model):
    owner = models.ForeignKey(Person, on_delete=models.CASCADE)
    name = models.CharField(max_length=250)
    weight = models.CharField(max_length=250)
    picture = models.CharField(max_length=250, default='')
    is_favourite = models.BooleanField(default=False)
    def __str__(self):
        return self.name
>>>>>>> 876b41aeb823c6e366286fa3d8fee5e3c2b1eb21
