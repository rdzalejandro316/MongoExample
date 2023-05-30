import pymongo

myclient = pymongo.MongoClient("mongodb+srv://sa:12345@cluster0.tgvqm2s.mongodb.net/?retryWrites=true&w=majority")
mydb = myclient["alejobd"]

try:
    print(myclient.list_database_names())
except Exception as e:
    print(e)
