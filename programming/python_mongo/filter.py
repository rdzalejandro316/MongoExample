import pymongo
import getConfig as config

myclient = pymongo.MongoClient(config._KEY_MONGO)
mydb = myclient[config._KEY_BD_MOGO]
mycol = mydb["Products"]

myquery = { "Name": "A2" }

mydoc = mycol.find(myquery)

for x in mydoc:
  print(x)