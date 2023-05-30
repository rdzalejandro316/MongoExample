import pymongo
import getConfig as config

myclient = pymongo.MongoClient(config._KEY_MONGO)
mydb = myclient[config._KEY_BD_MOGO]
mycol = mydb["Products"]

mydoc = { "Name": "A2", "Stock": 100}
x = mycol.insert_one(mydoc)
print(x)