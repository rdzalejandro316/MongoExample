import pymongo
import getConfig as config

myclient = pymongo.MongoClient(config._KEY_MONGO)
mydb = myclient[config._KEY_BD_MOGO]
mycol = mydb["Products"]

myquery = { "Name": "A2" }
newvalues = { "$set": { "Stock": 150 } }

mycol.update_one(myquery, newvalues)

#print "customers" after the update:
for x in mycol.find():
  print(x)