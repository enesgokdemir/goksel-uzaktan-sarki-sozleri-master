import json

import uzaktan
from fastapi import FastAPI

app = FastAPI()


@app.get("/")
async def index():
    return uzaktan.sozler()
