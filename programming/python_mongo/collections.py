import pymongo
import getConfig as config

myclient = pymongo.MongoClient(config._KEY_MONGO)
mydb = myclient[config._KEY_BD_MOGO]
mycol = mydb["Products"]

try:    
    print(mydb.list_collection_names())

    for x in mycol.find():
        print(x)
    
except Exception as e:
    print(e)
