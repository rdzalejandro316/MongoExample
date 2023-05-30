import pymongo

myclient = pymongo.MongoClient("mongodb+srv://sa:12345@cluster0.tgvqm2s.mongodb.net/?retryWrites=true&w=majority")
mydb = myclient["alejobd"]

try:
    myclient.admin.command('ping')    
    print("Pinged your deployment. You successfully connected to MongoDB!")    
except Exception as e:
    print(e)
