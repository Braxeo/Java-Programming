# -*- coding: utf-8 -*-
# Generated by Django 1.11.7 on 2017-11-16 12:31
from __future__ import unicode_literals

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('Person', '0001_initial'),
    ]

    operations = [
        migrations.AddField(
            model_name='person',
            name='profile_picture',
            field=models.CharField(default='', max_length=250),
        ),
    ]
