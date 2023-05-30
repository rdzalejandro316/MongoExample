import pymongo
import getConfig as config

myclient = pymongo.MongoClient(config._KEY_MONGO)
mydb = myclient[config._KEY_BD_MOGO]
mycol = mydb["Products"]

myquery = { "Name": "A1" }

mycol.delete_one(myquery)